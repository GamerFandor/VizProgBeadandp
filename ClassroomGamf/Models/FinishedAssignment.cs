using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomGamf.Models
{
    public class FinishedAssignment
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null;

        public DateTime Date { get; set; }

        public byte[] File { get; set; }

        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; } = null;
    }

}
