using System.Security.Cryptography;
using System.Text;
using static OOP.Domain.Enums;

namespace OOP.Domain.Entities
{
    public abstract class User
    {
        // init chỉ gán khi khởi tạo object
        public Guid Id { get; init; }
        // Thông tin cá nhân
        public string Name { get; init; }
        public string Phone { get; init; }
        // Mật khẩu
        public string Password { get; protected set; }
        // Trạng thái tài khoản
        public bool IsActive { get; protected set; } = true;
        // Vai trò
        public UserRole Role { get; init; }
        protected User(Guid id, string name, string phone, string hashedPassword, bool isActive, UserRole role)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Password = hashedPassword;
            IsActive = isActive;
            Role = role;
        }
    }
}
