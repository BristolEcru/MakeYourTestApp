
namespace MakeYourTestApp
{
    public class User : UserBase
    {
   
        public override string Name { get; set; }
        public override int Score { get; set; }

        public override List<TestClass> TestClasses { get; set; }

        public User(string name)
        {
            Id++;
            this.Name = name;
            this.Score = 0;
        }

        public TestClass CreateTest()
        {
            TestClass testClass = new TestClass("");
            TestClasses.Add(testClass);

            return testClass;
        }
    }
}
