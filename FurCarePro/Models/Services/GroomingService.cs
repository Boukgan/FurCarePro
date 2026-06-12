using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurCarePro.Models
{
    public class GroomingService
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
    }
}