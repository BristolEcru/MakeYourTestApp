

namespace MakeYourTestApp
{
    public static class Menu
    {
        public static void Run()
        {

            Console.WriteLine("*****************************");
            Console.WriteLine("Welcome to MAKE YOUR TEST APP");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            var pamela = new User("Pamela");

            do
            {
                Console.WriteLine("Create new test -> press 1");
                Console.WriteLine("Chose test to revise -> press 2");
                Console.WriteLine("Exit -> press 3");

                var choice = Console.ReadLine();
                int number=3;
                try
                {
                     number = Int32.Parse(choice);

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong choice. Try again. Exception caught: {e}");
                }
                

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Name your new test: ");
                        var name = Console.ReadLine();
                        if (name != null)
                        {
                            var test = new TestClass(name);
                            Console.WriteLine($"\n Provide questions and answers for your test \"{name}\"");
                            Console.WriteLine(" When you are done, press \"q\" ");
                            test.CreateTest();
                        }

                        break;
                    case 2:
                        Console.WriteLine("Chose your test set");
                        TestsContainer.Instance.DisplayTests();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("You must type 1, 2 or 3 only");
                        break;

                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }
    }
}
