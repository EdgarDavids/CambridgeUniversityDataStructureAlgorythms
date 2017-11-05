using System.Collections;

namespace Basic
{
    public class UserStack
    {
        private ArrayList _list;
        private int _peekIndex;

        public UserStack() {
            _list = new ArrayList();
            _peekIndex = -1;
        }

        public int Count { get { return _list.Count; } }

        public object Push(object item) {
            int index = _list.Add(item);
            _peekIndex++;
            return _list[index];
        }

        public object Pop() {
            if (Count <= 0) return null;
            object item = _list[_peekIndex];
            _list.RemoveAt(_peekIndex);
            _peekIndex--;
            return item;
        }

        public void Clear() {
            _list.Clear();
            _peekIndex = -1;
        }

        public object Peek(){
            return _list[_peekIndex];
         }
    }
}
