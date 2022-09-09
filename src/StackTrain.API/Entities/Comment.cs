using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }

        public Question Question { get; set; }
        public Guid QuestionId { get; set; }

        public Answer Answer { get; set; }
        public Guid AnswerId { get; set; }


    }
}
