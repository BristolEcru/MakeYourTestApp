namespace MakeYourTestApp
{
    public abstract class UserBase
    {
        public static int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract int Score { get; set; }
        public abstract List<TestClass> TestClasses { get; set; }

    
    }
}