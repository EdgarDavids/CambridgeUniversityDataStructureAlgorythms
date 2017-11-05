using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class UserQueue
    {
        private ArrayList arrayList;

        public UserQueue() {
            arrayList = new ArrayList();
        }

        public object Enqueue(object item) {
            arrayList.Add(item);

            return arrayList[arrayList.Count - 1];
        }

        public object Dequeue() {
            object item = arrayList[0];
            arrayList.RemoveAt(0);

            return item;
        }

        public object Peek() {
            return arrayList[0];
        }

        public void Clear() {
            arrayList.Clear();
        }

        public int Count {
            get { return arrayList.Count; }
        }
    }
}
