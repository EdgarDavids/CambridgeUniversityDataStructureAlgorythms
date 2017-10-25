namespace BasicSort
{
    public interface ISort<T>{
        void DoSort();
        void DoReverseSort();
        T[] SortSet { get; set; }
    }
}
