using System.ComponentModel.DataAnnotations;


namespace UltraLock.Server.Model.UserDto
{
    public abstract class UserBase
    {
        public bool IsAdmin { get; set; } = false;
        [Required]
        public abstract string Name { get; set; }
        [EmailAddress]
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
