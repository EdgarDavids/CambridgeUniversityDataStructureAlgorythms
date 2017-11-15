using Basic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.c5.l3
{
    public class HelpDeskEmulator{

        public static void Apply()
        {
            int elementsInActiveQueue = 5;
            IList<HelpDeskTask> tasks = new List<HelpDeskTask>() {
                new HelpDeskTask() { Priority = 2, Id = 1101, RequestTime = new DateTime(2017,11,01)},
                new HelpDeskTask() { Priority = 4, Id = 1102, RequestTime = new DateTime(2017,11,02)},
                new HelpDeskTask() { Priority = 1, Id = 1103, RequestTime = new DateTime(2017,11,03)},
                new HelpDeskTask() { Priority = 1, Id = 1104, RequestTime = new DateTime(2017,11,04)},
                new HelpDeskTask() { Priority = 1, Id = 1105, RequestTime = new DateTime(2017,11,05)},
                new HelpDeskTask() { Priority = 1, Id = 1106, RequestTime = new DateTime(2017,11,06)},
                new HelpDeskTask() { Priority = 5, Id = 1107, RequestTime = new DateTime(2017,11,07)},
                new HelpDeskTask() { Priority = 2, Id = 1108, RequestTime = new DateTime(2017,11,08)},
                new HelpDeskTask() { Priority = 0, Id = 1109, RequestTime = new DateTime(2017,11,09)},
                new HelpDeskTask() { Priority = 1, Id = 1110, RequestTime = new DateTime(2017,11,10)},
                new HelpDeskTask() { Priority = 4, Id = 1111, RequestTime = new DateTime(2017,11,11)},
                new HelpDeskTask() { Priority = 1, Id = 1112, RequestTime = new DateTime(2017,11,12)}
            };
            PriorityQueue activeQueue = new PriorityQueue();

            while (tasks.Count > 0) {
                Console.WriteLine("Portion of items: ");
                while (activeQueue.Count < elementsInActiveQueue && tasks.Count > 0) {
                    PQItem item = new PQItem();
                    item.priority = tasks[0].Priority;
                    item.item = tasks[0].Id;
                    activeQueue.Enqueue(item);
                    tasks.RemoveAt(0);
                }

                while (activeQueue.Count > 0) {
                    PQItem item = (PQItem)activeQueue.Dequeue();
                    Console.WriteLine("{0} - {1}", item.priority, item.item);
                }
            }

        }

    }
}
