using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarsCRUD.ViewModels.Car
{
    public class IndexCarViewModel
    {
        [Key]
        public int CarID { get; set; }
        [Display(Name = "Название машины")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Column(TypeName = "varchar(50)")]
        public string CarName { get; set; }
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Column(TypeName = "varchar(250)")]
        public string CarDesc { get; set; }
        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public short CarPrice { get; set; }
    }
}
