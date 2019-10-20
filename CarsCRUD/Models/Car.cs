using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarsCRUD.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        [DisplayName("Название машины")]
        [Column(TypeName ="varchar(50)")]
        public string CarName { get; set; }
        [DisplayName("Описание")]
        [Column(TypeName = "varchar(250)")]
        public string CarDesc { get; set; }
        [DisplayName("Цена")]
        public short CarPrice { get; set; }

    }
}
