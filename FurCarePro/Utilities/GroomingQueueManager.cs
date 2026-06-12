using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurCarePro.Models.Appointments;

namespace FurCarePro.Utilities
{
    public static class GroomingQueueManager
    {
        public static Queue<Appointment>
            GroomingQueue =
            new Queue<Appointment>();
    }
}

