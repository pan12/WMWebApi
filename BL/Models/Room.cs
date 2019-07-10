using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BL.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int ApartamentNumber { get; set; }
        public int HouseId { get; set; }
        [ForeignKey("HouseId")]
        public House House { get; set; }
    }
}
