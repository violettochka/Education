using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Data
    {
        public string Topic { get; set; }
        public string Message { get; set; }

        public Data(string topic, string message) 
        {
            Topic = topic;
            Message = message;
        }

        public override string ToString()
        {
            return Topic;
        }
    }
}
