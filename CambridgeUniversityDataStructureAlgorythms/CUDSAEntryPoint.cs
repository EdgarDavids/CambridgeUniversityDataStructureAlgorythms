using Basic;
using System;
using System.Collections;

namespace CambridgeUniversityDataStructureAlgorythms
{
    class CUDSAEntryPoint
    {
        static void Main(string[] args)
        {
            Timing.Timing tObj = new Timing.Timing();
            tObj.StartTime();
            Exercises.c2.l2.GradeCalculator.Calculate();
            tObj.StopTime();
            Console.WriteLine("Totally {0} seconds ", tObj.GetDuration().Seconds);
            Console.ReadLine();
        }
    }
}
