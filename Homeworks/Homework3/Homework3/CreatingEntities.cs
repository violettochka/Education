using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public static class CreatingEntities
    {
        public static void Create()
        {
            User user1 = Initialization.CreateUser(Guid.NewGuid(), "Admin");
            User user2 = Initialization.CreateUser(Guid.NewGuid(), "Moderator");
            User user3 = Initialization.CreateUser(Guid.NewGuid(), "Editor");
            User user4 = Initialization.CreateUser(Guid.NewGuid(), "User");

            Data data1 = Initialization.CreateData("topic1", "This is first message with my request");
            Data data2 = Initialization.CreateData("topic2", "ms2");
            Data data3 = Initialization.CreateData("topic3", "message 3 I want to discuss....");
            Data data4 = Initialization.CreateData("topic4", "In this message i want to show you...");

            Request request1 = Initialization.CreateRequestAndAdd("request1", DateTime.Today.AddDays(-2), data1, user1);
            Request request2 = Initialization.CreateRequestAndAdd("request2", DateTime.Today, data2, user2);
            Request request3 = Initialization.CreateRequestAndAdd("request3", DateTime.Today.AddDays(1), data3, user3);
            Request request4 = Initialization.CreateRequestAndAdd("request4", DateTime.Today.AddDays(-1), data4, user4);
        }
    }
}
