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

        public void Enqueue(object item) {
            arrayList.Add(item);
        }

        public void Dequeue() {
            arrayList.RemoveAt(0);
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
