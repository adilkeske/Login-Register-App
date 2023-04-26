using System.ComponentModel.DataAnnotations;

namespace Login_Register_App.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
