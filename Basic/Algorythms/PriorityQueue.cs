using System.Collections;
using System.Collections.Generic;

namespace Basic.Algorythms
{

    public struct PQItem {
        public int priority { get; set; }
        public object item { get; set; }
    }
    public class PriorityQueue: Queue {

        public override object Dequeue(){
            object[] list = new object[this.Count];
            int max_index = 0;
            list = this.ToArray();
            int max_priority = ((PQItem)list[0]).priority;

            for (int i = 1; i < list.Length; i++) {
                if (max_priority >= ((PQItem)list[i]).priority) continue;
                    max_priority = ((PQItem)list[i]).priority;
                    max_index = i;
            }
            this.Clear();

            for (int i = 0; i < list.Length; i++){
                if (i != max_index) this.Enqueue(list[i]);
            }

            return list[max_index];
        }
    }
}
