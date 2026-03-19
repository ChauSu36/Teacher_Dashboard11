using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using Web_service.Models;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly FirebaseService _firebase;
    private readonly IConfiguration _config;

    public AuthController(FirebaseService firebase, IConfiguration config)
    {
        _firebase = firebase;
        _config = config;
    }

    [HttpPost("register")] // POST /api/auth/register
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        // 1. Kiểm tra rỗng
        if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password) || string.IsNullOrWhiteSpace(request.ConfirmPassword))
        {
            return BadRequest(new { success = false, message = "Vui lòng không để trống các trường!" });
        }

        // 2. Validate Email
        if (!Regex.IsMatch(request.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            return BadRequest(new { success = false, message = "Email không đúng dạng!" });
        }

        // 3. Validate Password match
        if (request.Password != request.ConfirmPassword)
        {
            return BadRequest(new { success = false, message = "Mật khẩu và Xác nhận mật khẩu phải giống nhau!" });
        }

        // 4. Kiểm tra tài khoản trùng lặp
        var existingUser = await _firebase.FindUser(request.Email);
        if (existingUser.user != null)
        {
            return BadRequest(new { success = false, message = "Tên tài khoản (Email) này đã tồn tại!" });
        }

        // 5. Tạo User mới
        UserModel newUser = new UserModel { username = request.Email, password = request.Password };
        bool isSuccess = await _firebase.RegisterUser(newUser);

        if (isSuccess)
        {
            return Ok(new { success = true, message = "Đăng ký thành công!" });
        }
        else
        {
            return StatusCode(500, new { success = false, message = "Lỗi Firebase: Đăng ký thất bại!" });
        }
    }

    [HttpPost("login")] // POST /api/auth/login
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        // ❌ check rỗng
        if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
        {
            return BadRequest(new
            {
                success = false,
                message = "Thiếu dữ liệu"
            });
        }

        // 🔍 tìm user
        var result = await _firebase.FindUser(request.Username);

        if (result.user == null)
        {
            return Unauthorized(new
            {
                success = false,
                message = "Không tồn tại user"
            });
        }

        // 🔐 check password
        if (result.user.password != request.Password)
        {
            return Unauthorized(new
            {
                success = false,
                message = "Sai mật khẩu"
            });
        }

        // ✅ OK
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"] ?? ""));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, result.user.username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(2),
            signingCredentials: credentials);

        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        return Ok(new
        {
            success = true,
            message = "Đăng nhập thành công",
            token = tokenString
        });
    }
}
