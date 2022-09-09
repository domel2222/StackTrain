using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities
{
    public class Answer
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public Rate Rate { get; set;}
    }
}
