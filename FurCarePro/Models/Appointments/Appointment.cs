using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurCarePro.Models.Appointments
{
    public class Appointment
    {
        
        public int AppointmentID { get; set; }

        public int PetID { get; set; }

        public int ServiceID { get; set; }

        public string PetName { get; set; }

        public string ServiceName { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; }
    } 
}
