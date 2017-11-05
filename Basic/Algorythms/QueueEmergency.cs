using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Algorythms
{
    public static class QueueEmergency
    {

        public struct PQItem
        {
            public int priority;
            public string name;
        }

        public class PQueue : Queue
        {
            public override object Dequeue()
            {
                object[] items;
                int toppriority, minindex = 0;
                items = this.ToArray();

                toppriority = ((PQItem)items[0]).priority;
                for (int i = 0; i < items.Length; i++) {
                    if (((PQItem)items[i]).priority < toppriority) {
                        toppriority = ((PQItem)items[i]).priority;
                        minindex = i;
                    }
                }
                this.Clear();
                for (int i = 0; i < items.Length; i++) if (i != minindex) this.Enqueue(items[i]);
                return items[minindex];
            }

        }
        public static void Apply() {
            PQueue erwait = new PQueue();
            PQItem[] erPatient = new PQItem[4];
            PQItem nextPatient;
            erPatient[0].name = "Joe Smith";
            erPatient[0].priority = 1;
            erPatient[1].name = "Mary Brown";
            erPatient[1].priority = 0;
            erPatient[2].name = "Sam Jones";
            erPatient[2].priority = 3;
            for (int x = 0; x < erPatient.Length; x++)
                erwait.Enqueue(erPatient[x]);
            nextPatient = (PQItem)erwait.Dequeue();
            Console.WriteLine(nextPatient.name);
        }
        
    }
}
