using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
