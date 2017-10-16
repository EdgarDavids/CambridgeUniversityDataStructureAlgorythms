namespace Exercises.c2.l1
{
    public class Grade
    {
        private int[] grades;
        private int total;

        public Grade(params int[] grades) {
            this.grades = new int[100];
            total = grades.Length;
            for (int i = 0; i < grades.Length; i++) this.grades[i] = grades[i];
        }

        public double Average() {
            int sum = 0;
            for (int i = 0; i < total; i++) sum += grades[i];

            return total ==0 ? 0 : sum / total;
        }

        public int Highest() {
            int max = 0;

            for (int i = 0; i < total; i++) if (max<grades[i]) max=grades[i];

            return max;
        }

        public int Lowest() {
            int min = 1000;

            for (int i = 0; i < total; i++) if (min > grades[i]) min = grades[i];

            return min;
        }
    }
}
