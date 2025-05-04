using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassroomGamf.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null;
        public string Email { get; set; } = null;
        public string Password { get; set; } = null;
        public string Role { get; set; } = "student";

        public ICollection<Log> Logs { get; set; } = new List<Log>();
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<UserToGroup> UserGroups { get; set; } = new List<UserToGroup>();
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
        public ICollection<FinishedAssignment> FinishedAssignments { get; set; } = new List<FinishedAssignment>();
    }
}
