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
    }
}
