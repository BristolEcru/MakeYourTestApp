

using System.IO;

namespace MakeYourTestApp
{
    public class TestClass: TestBase<TestsContainer>, ITest
    {
        public string FileA { get; set; }

        public string FileB { get; set; }

        public string TestName { get; set; }


        public TestClass(string testName)
        {

            TestName = testName;
            FileA = testName+"A.txt";
            FileB = testName+"B.txt";

        }

        
        public void WriteToFile(string fileName, string input)
        {
            string filePath = Path.Combine(folderPath, fileName);

            if (!File.Exists(fileName))
            {
                using (var writer = File.CreateText(filePath))
                writer.WriteLine(input);

            }
            else
                using (var writer = File.AppendText(filePath))
            {
                writer.WriteLine(input);
            }
        } 

        public void CreateTest() 
        {
            folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tests");
            if(!Directory.Exists(folderPath))
            { Directory.CreateDirectory(folderPath); }

            string stopMark;
            do
            {
                Console.WriteLine("Question:");
                WriteToFile(Path.Combine(folderPath, FileA), Console.ReadLine());
                Console.WriteLine("Answer:");
                WriteToFile(Path.Combine(folderPath, FileB), Console.ReadLine());
                Console.WriteLine("Press any key to continue or q to quit");
                stopMark = Console.ReadLine();
            } while (stopMark!= "q");
            TestsContainer.Instance.AddTest(this);
            Console.WriteLine($"Now you have your test \"{ TestName}\" ready to use");

        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine();
            }
        }

    }
}
