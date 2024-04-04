using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.DestinationDTOs
{
    public class AddDestinationDTO
    {
        public string Country { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public string DayNight { get; set; }
        public int Capacity { get; set; }
    }
}
