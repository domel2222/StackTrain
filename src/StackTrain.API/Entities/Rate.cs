using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities
{
    public class Rate
    {
        public int Id { get; set; }
        public int Score { get; set; }

        public Answer Answer { get; set; }
        public Guid AnswerId { get; set; }
    }
}
