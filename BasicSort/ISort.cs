namespace BasicSort
{
    public interface ISort<T>{
        void DoSort();
        T[] SortSet { get; set; }
    }
}
