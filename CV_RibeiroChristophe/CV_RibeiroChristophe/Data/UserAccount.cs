using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_RibeiroChristophe.Data
{
    public class UserAccount
    {
        public int Id { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }
		[Required, ForeignKey(nameof(Role))]
		public int roleId { get; set; }

    }
}
