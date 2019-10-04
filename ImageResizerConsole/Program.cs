using System;

namespace ImageResizerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var aIconGenerator = new AndroidIconGenerator();
            aIconGenerator.GenerateIcons("testIcon.png", "TestAndroid");
            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
