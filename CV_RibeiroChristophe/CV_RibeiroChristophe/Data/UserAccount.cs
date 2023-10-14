using System.ComponentModel.DataAnnotations;

namespace CV_RibeiroChristophe.Data
{
    public class UserAccount
    {
        public int Id { get; set; }
        [Required]
        public string? login { get; set; }
        [Required]
        public string? password { get; set; }
		[Required]
		public string? role { get; set; }

    }
}
