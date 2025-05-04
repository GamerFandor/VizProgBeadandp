using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassroomGamf.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = null;
        public string Message { get; set; } = null;
        public DateTime Date { get; set; } = DateTime.Now;

        public int AuthorId { get; set; }
        public User Author { get; set; } = null;

        public int GroupId { get; set; }
        public Group Group { get; set; } = null;
        public int Type { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }

}
