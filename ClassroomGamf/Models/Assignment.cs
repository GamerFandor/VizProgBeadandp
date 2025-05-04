using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomGamf.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; } = null;
        public string Message { get; set; } = null;
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime PastDue { get; set; }

        public byte[] File { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; } = null;

        public int GroupId { get; set; }
        public Group Group { get; set; } = null;
    }

}
