using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MakeYourTestApp
{
    public class TestsContainer : TestBase<TestsContainer>
    {

        private List<TestClass> container;

        public TestsContainer() 
        {
            container = new List<TestClass>();
        }

       

        public void AddTest(TestClass test)
        {
            container.Add(test);
        }

        public List<TestClass> GetAllTests()
        {
            LoadTestsFromFiles(folderPath);
            return container;
        }

        public void LoadTestFromFile(string filename)
        {
            string path = Path.Combine(folderPath, filename);
            if(!File.Exists(path))
            {
                Console.WriteLine($"File {filename} does not exist");
                return;
            }
            else
            {

            }

            TestClass test= new TestClass(filename);
            AddTest(test);
            
        }

        public void LoadTestsFromFiles(string folderPath)
        {
            container.Clear();

            if (Directory.Exists(folderPath))
            {
                foreach(string file in Directory.GetFiles(folderPath, $"*.txt"))
                {
                    try
                    {
                        using (var reader = new StreamReader(folderPath))
                        {
                            //XmlSerializer serializer = new XmlSerializer(typeof(TestClass));

                            //TestClass test = (TestClass)serializer.Deserialize(reader);

                            //AddTest(test);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading files from {folderPath} : {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"The folder {folderPath} does not exist");
                
            }

          

        }
        public void DisplayTests()
        {
            GetAllTests();
            foreach (TestClass test in container)
            {
                Console.WriteLine($"{test.TestName.ToString()}");
            }

        }
    }
}
