using System;

namespace ImageResizerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: ImageResizer [PathToOriginalImage] [OutputDirectory]");
                return;
            }
            string imagePath = args[0];
            string outputDirectory = args[1];

            var aIconGenerator = new AndroidIconGenerator();
            var iIconGenerator = new AppleIconGenerator();

            aIconGenerator.GenerateIcons(imagePath, outputDirectory);
            iIconGenerator.GenerateAllIcons(imagePath, outputDirectory);
            Console.WriteLine($"Generated icons at: { outputDirectory }");
        }
    }
}
