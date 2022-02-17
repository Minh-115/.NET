using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    [Table("nhanvien")]
    public class nhanvien
    {
        internal IEnumerable<object> nhanviens;

        [Key]
        [Display(Name = "Mã nhân viên")]

        public int id { get; set; }
        [Display(Name = "Họ Tên")]
        [Required(ErrorMessage = "Chưa nhập tên")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]

        public string ten { get; set; }
        [Display(Name = "Vị Trí")]
        [Required(ErrorMessage = "Chưa nhập vị trí")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
        public string vitri { get; set; }
        [Display(Name = "Lương")]
        [Required(ErrorMessage = "Chưa nhập lương")]
        public double luong { get; set; }

    }
}
