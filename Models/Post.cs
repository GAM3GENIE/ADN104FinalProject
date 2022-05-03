using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADN104FinalProjectWozU.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TimeStamp { get; set; }
        public string CreatedBy { get; set; }
    }
}
