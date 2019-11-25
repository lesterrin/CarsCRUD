using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CarsCRUD.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        [Display(Name = "CarName")]
        [Required(ErrorMessage = "RequiredField")]
        [Column(TypeName ="varchar(50)")]
        public string CarName { get; set; }
        [Display(Name = "CarDescription")]
        [Required(ErrorMessage = "RequiredField")]
        [Column(TypeName = "varchar(250)")]
        public string CarDesc { get; set; }
        [Display(Name = "CarPrice")]
        [Required(ErrorMessage = "RequiredField")]
        public short CarPrice { get; set; }
        
    }
}
