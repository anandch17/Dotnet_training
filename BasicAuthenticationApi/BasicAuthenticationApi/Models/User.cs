using Microsoft.VisualBasic;

namespace BasicAuthenticationApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public DateOnly Date { get; set; } 

        public Boolean IsActive { get; set; } = true;
        public string Password { get; set; }
    }
}
