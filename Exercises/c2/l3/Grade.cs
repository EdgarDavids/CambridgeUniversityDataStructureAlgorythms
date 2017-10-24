using System.Collections;

namespace Exercises.c2.l3
{
    public class Grade
    {
        private ArrayList grades;
        
        public Grade(params int[] grades) {
            this.grades = new ArrayList();

            foreach (int grade in grades) this.grades.Add(grade);
        }

        public double Average() {
            int sum = 0;
            
            foreach (object grade in grades) sum += int.Parse(grade.ToString());

            return grades.Count == 0 ? 0 : sum / grades.Count;
        }

        public int Highest() {
            int max = 0;

            foreach (object grade in grades) if (max < int.Parse(grade.ToString())) max = int.Parse(grade.ToString());

            return max;
        }

        public int Lowest() {
            int min = 1000;

            foreach (object grade in grades) if (min > int.Parse(grade.ToString())) min = int.Parse(grade.ToString());

            return min;
        }
    }
}
