using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Message
    {
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
        public string MessageText { get; set; }
        
        public override string ToString()
        {
            return $"\tDate: {DateTime:F}\n\tName: {Name}\n\tMessage: {MessageText}";
        }
    }
}
