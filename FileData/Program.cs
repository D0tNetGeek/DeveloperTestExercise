using System;
using FileData.Service;

namespace FileData
{
    public static class Program
    {
        public static bool TryParseArguments(string[] args, out string functionality, out string fileName)
        {
            if (args == null || args.Length != 2)
            {
                functionality = string.Empty;
                fileName = string.Empty;
                return false;
            }

            functionality = args[0];
            fileName = args[1];

            return true;
        }

        public static void Main(string[] args)
        {
            if (!TryParseArguments(args, out var functionality, out var fileName))
            {
                Console.WriteLine($"Error : invalid usage");
                Console.WriteLine($"Use -v or --v or --version or /v to get the version of the file");
                Console.WriteLine($"Use -s or --s or --size or /s to get the size of the file");
            }

            var compositeFunctionalityOnFile = new FunctionalityMapper();

            try
            {
                Console.WriteLine(compositeFunctionalityOnFile.GetFunctionalityAssociatedTo(functionality).Execute(fileName));
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                Console.WriteLine($"Error : unknown functionnality {functionality}");
            }

            Console.ReadKey();
        }
    }
}
