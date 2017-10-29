namespace BasicSearch
{
    public interface ISearch
    {
        int[] SearchSet { get; set; }
        int Attempts { get; set; }
        bool Search(int value);

        void SearchReport(int value);
    }
}
