using System.ComponentModel.DataAnnotations;

namespace CV_RibeiroChristophe.Data
{
    public class UserAccount
    {
        [Required]
        public string? login { get; set; }
        [Required]
        public string? password { get; set; }
        public string? role { get; set; }

    }
}
