using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomGamf.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;

        public ICollection<UserToGroup> UserGroups { get; set; } = new List<UserToGroup>();
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
    }

}
