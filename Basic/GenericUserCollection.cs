using System.Collections;

namespace Basic
{
    public class GenericUserCollection<T>
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
    }
}
