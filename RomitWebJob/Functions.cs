using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomitWebJob
{
    public class Functions
    {
        public static void WriteMessage([QueueTrigger("romitmessagequeue")] string message)
        {
            Console.WriteLine(message);

            //using (var db = new RomitMessagesEntities())
            //{
            //    db.QueueMessages.Add(new QueueMessage()
            //        {
            //            MessageBody = message,
            //            MessageOn = DateTime.UtcNow
            //        });
            //    db.SaveChanges();
            //}
        }
    }
}
