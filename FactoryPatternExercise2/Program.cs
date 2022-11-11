namespace FactoryPatternExercise2
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
				Console.WriteLine("Which type of database do you want to use?\n");
				Console.WriteLine("Please choose either 'list', 'sql' or 'mongo'.");
                string input = Console.ReadLine();
                var accessType = DataAccessFactory.GetDataAccessType(input);
				if (accessType != null)
                {
					Console.Clear();
					accessType.LoadData();
                    accessType.SaveData();
					Console.ReadLine();
				}
                else
                {
					Console.WriteLine("Entry is not valid press enter to try again..");
					Console.ReadLine();
				}
			}

        }

    }
}
