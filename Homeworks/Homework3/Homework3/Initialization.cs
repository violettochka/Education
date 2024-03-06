using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public static class Initialization
    {
        public static User CreateUser(Guid userId,
                                      string UserRole) 
        {
            return new User(userId, UserRole);
        }

        public static Data CreateData(string topic,
                                      string message)
        {
            return new Data(topic, message);
        }

        public static Request CreateRequestAndAdd(string name,
                                            DateTime timeStamp,
                                            Data data,
                                            User sender) 
        {
            var request = new Request(name, timeStamp, data, sender);
            Request.collection.Add(request);

            return request;
        }
    }
}
