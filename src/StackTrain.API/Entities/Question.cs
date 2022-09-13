using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Tag> Tags { get; set; } = new List<Tag>();
        
    }
}
