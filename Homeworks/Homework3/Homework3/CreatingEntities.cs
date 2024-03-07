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
            User user1 = new User(Guid.NewGuid(), "Admin");
            User user2 = new User(Guid.NewGuid(), "Moderator");
            User user3 = new User(Guid.NewGuid(), "Editor");
            User user4 = new User(Guid.NewGuid(), "User");

            Data data1 = new Data("topic1", "This is first message with my request");
            Data data2 = new Data("topic2", "ms2");
            Data data3 = new Data("topic3", "message 3 I want to discuss....");
            Data data4 = new Data("topic4", "In this message i want to show you...");

            Request request1 = new Request("request1", DateTime.Today.AddDays(-2), data1, user1);
            Request request2 = new Request("request2", DateTime.Today, data2, user2);
            Request request3 = new Request("request3", DateTime.Today.AddDays(1), data3, user3);
            Request request4 = new Request("request4", DateTime.Today.AddDays(-1), data4, user4);
        }
    }
}
