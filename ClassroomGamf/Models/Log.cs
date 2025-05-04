using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomGamf.Models
{
    public class Log
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; } = null;
    }
}
