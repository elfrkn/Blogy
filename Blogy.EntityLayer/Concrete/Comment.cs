using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.EntityLayer.Concrete
{
    public class Comment
    {
        public  int CommentId { get; set; }
        public string Content { get; set; }

        public DateTime  CommentDate { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public  string  NamSurname { get; set; }
        public  string Email { get; set; }
        public  bool  Status { get; set; }
       
    }
}
