using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Request
    {
        public static List<Request> collection = new List<Request>(); 
        public string Name { get; set; }
        public DateTime TimeStamp { get; set; }
        public Data Data { get; set; }
        public User Sender { get; set; }

        public Request(string name, DateTime timeStamp, Data data, User sender)
        {
            Name = name;
            TimeStamp = timeStamp;
            Data = data;
            Sender = sender;
        }

        public override string ToString()
        {
            return $"Name: {Name}, \n" +
                   $"DateTime: {TimeStamp}, \n" +
                   $"Data: {Data}, \n" +
                   $"Sender: {Sender}";
        }
    }
}
