using Basic;
using System;
using System.Collections;

namespace CambridgeUniversityDataStructureAlgorythms
{
    class CUDSAEntryPoint
    {
        static void Main(string[] args)
        {
            //IntroCollectionsGenerics.IntroCollectionGenericHelper.BasicOperationsCollection();
            //IntroCollectionsGenerics.IntroCollectionGenericHelper.BasicOperationsCollectionExercise();
            //IntroCollectionsGenerics.IntroCollectionGenericHelper.DoSwap();
            //Exercises.c1.l1.ExamLauncher.Launch();
            ArrayList arr1 = new ArrayList();
            UserCollection arr2 = new UserCollection();
            arr1 = Exercises.c1.l3.Helper.BuildArray(arr1);
            arr2 = Exercises.c1.l3.Helper.BuildArray(arr2);

            Timing.Timing tObj = new Timing.Timing();
            tObj.StartTime();
            Exercises.c1.l3.Helper.GetArray(arr1);
            tObj.StopTime();
            Console.WriteLine("Totally {0} seconds ", tObj.GetDuration().Seconds);
            Console.ReadLine();
            tObj.StartTime();
            Exercises.c1.l3.Helper.GetArray(arr2);
            tObj.StopTime();
            Console.WriteLine("Totally {0} seconds ", tObj.GetDuration().Seconds);

            Console.ReadLine();
        }
    }
}
