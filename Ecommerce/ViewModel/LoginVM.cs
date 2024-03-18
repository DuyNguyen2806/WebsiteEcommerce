using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModel
{
    public class LoginVM
    {
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage =("*"))]

        public string UserName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = ("*"))]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
