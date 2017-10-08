namespace BasicOperations
{
    public class Basic
    {
        public static void Swap<T>(ref T value1, ref T value2) {
            T temp;

            temp = value1;
            value1 = value2;
            value2 = temp;


        }
    }
}
