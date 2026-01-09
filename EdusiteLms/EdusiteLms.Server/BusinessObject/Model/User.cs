using EdusiteLms.Server.BusinessObject.Enum;
using System.Net;

namespace EdusiteLms.Server.BusinessObject.Model
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public UserRole Role { get; set; }
    }
}
