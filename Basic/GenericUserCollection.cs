using System;
using System.Collections;
using System.Collections.Generic;

namespace Basic
{
    public class GenericUserCollection<T>:IEnumerable<T>
    {
        protected ArrayList InnerList { get; set; }

        public GenericUserCollection() {
            InnerList = new ArrayList();
        }
        public void Add(T item){
            InnerList.Add(item);
        }

        public void Remove(T item){
            InnerList.Remove(item);
        }

        public void Clear(){
            InnerList.Clear();
        }

        public int Count()
        {
            return InnerList.Count;
        }

       
        public IEnumerator GetEnumerator()
        {
            return InnerList.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (T item in InnerList) {
                yield return item;
            }
        }
    }
}
