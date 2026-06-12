using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurCarePro.Models.Feedbacks
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
    }
}
