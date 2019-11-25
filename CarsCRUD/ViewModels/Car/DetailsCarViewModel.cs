using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarsCRUD.ViewModels.Car
{
    public class DetailsCarViewModel
    {
        
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string CarDesc { get; set; }
        public short CarPrice { get; set; }
    }
}
