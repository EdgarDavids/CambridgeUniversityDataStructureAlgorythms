using System;

namespace Basic.Algorythms
{
    public static class QueueDancingLine
    {

        public static void Apply() {
            Dancer[] dancers = new Dancer[]{
                new Dancer() { Name="Jennifer Ingram", Sex=SexEnum.Female },
                new Dancer() { Name="Frank Opitz", Sex=SexEnum.Male },
                new Dancer() { Name="Terrill Beckerman", Sex=SexEnum.Male },
                new Dancer() { Name="Mike Dahly", Sex=SexEnum.Male },
                new Dancer() { Name="Beata Lovelace", Sex=SexEnum.Female },
                new Dancer() { Name="Raymond Williams", Sex=SexEnum.Male },
                new Dancer() { Name="Shirley Yaw", Sex=SexEnum.Female },
                new Dancer() { Name="Don Gundolf", Sex=SexEnum.Male },
                new Dancer() { Name="Bernica Tackett", Sex=SexEnum.Female },
                new Dancer() { Name="David Durr", Sex=SexEnum.Male },
                new Dancer() { Name="Mike McMillan", Sex=SexEnum.Male },
                new Dancer() { Name="Nikki Feldman", Sex=SexEnum.Female }
            };

            Console.WriteLine("Line is :");
            foreach (Dancer dancer in dancers) {

            }

            UserQueue activeDancers = new UserQueue();
            UserQueue males = new UserQueue();
            UserQueue females = new UserQueue();

            FormLine(males, SexEnum.Male, dancers);
            FormLine(females, SexEnum.Female, dancers);

            FillDancePole(activeDancers, females, males);
            PairLeft(activeDancers);
            FillDancePole(activeDancers, females, males);
            PairLeft(activeDancers);
            PairLeft(activeDancers);
            FillDancePole(activeDancers, females, males);
            FillDancePole(activeDancers, females, males);
        }

        private static void PairLeft(UserQueue activeDancers)
        {
            activeDancers.Dequeue();
            activeDancers.Dequeue();
            Console.WriteLine("2 dancers left dance pole");
        }

        private static void FillDancePole(UserQueue activeDancers, UserQueue females, UserQueue males)
        {

            while(activeDancers.Count !=6)
            {
                if ((females.Count == 0) || (males.Count==0)) break;
                Console.Write("Dancing pair : ");
                Console.Write(((Dancer)activeDancers.Enqueue(males.Dequeue())).Name);
                Console.Write(" - ");
                Console.Write(((Dancer)activeDancers.Enqueue(females.Dequeue())).Name);
                Console.WriteLine();
            }

            Console.WriteLine("Next Line : ");
            if (females.Count == 0)
                Console.Write("No more female partner");
            else
                Console.Write(((Dancer)females.Peek()).Name);
            Console.Write(" - ");
            if (males.Count == 0)
                Console.Write("No more male partner");
            else
                Console.Write(((Dancer)males.Peek()).Name);
            Console.WriteLine();


            if (females.Count == 0) Console.WriteLine("No more female partner");
            if (males.Count == 0) Console.WriteLine("No more male partner");
        }

        private static void FormLine(UserQueue line, SexEnum sex, Dancer[] dancers)
        {
            foreach (Dancer dancer in dancers) if (sex == dancer.Sex) line.Enqueue(dancer);
        }

        internal class Dancer {
            internal string Name { get; set; }
            internal SexEnum Sex { get; set; }
        }

        internal enum SexEnum {
            Male,
            Female
        }




    }
}
