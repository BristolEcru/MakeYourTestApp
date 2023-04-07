
namespace MakeYourTestApp
{
    public interface ITest
    {
        public string FileA { get; set; }
        public string FileB { get; set; }

        public string TestName { get; set; }


        public void WriteToFile(string fileName, string input);

        public void CreateTest();

        

    }
}
