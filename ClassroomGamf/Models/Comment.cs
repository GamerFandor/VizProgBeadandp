using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomGamf.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; } = null;
        public DateTime Date { get; set; } = DateTime.Now;

        public int AuthorId { get; set; }
        public User Author { get; set; } = null;

        public int PostId { get; set; }
        public Post Post { get; set; } = null;
    }

}
