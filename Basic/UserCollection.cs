using System.Collections;

namespace Basic
{
    public class UserCollection:CollectionBase
    {
        public void Add(object item) {
            InnerList.Add(item);
        }
        
        public void Remove(object item) {
            InnerList.Remove(item);
        }

        public new int Count(){
            return InnerList.Count;
        }

        public new void Clear() {
            InnerList.Clear();
        }

        public void Insert(int i, object item) {
            InnerList.Insert(i, item);
        }

        public bool Contains(object item) {
            return InnerList.Contains(item);
        }

        public int IndexOf(object item) {
            return InnerList.IndexOf(item);
        }

        public new void RemoveAt(int i) {
            InnerList.RemoveAt(i);
        }
    }
}
