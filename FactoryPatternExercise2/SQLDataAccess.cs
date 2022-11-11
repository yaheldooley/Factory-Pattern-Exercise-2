namespace FactoryPatternExercise2
{
	public partial class Program
    {
		public class SQLDataAccess : IDataAccess
		{
			public List<Product> LoadData()
			{
				Console.WriteLine($"I am reading data from SQLDataAccess database");
                return new List<Product>();
			}

			public void SaveData()
			{
				Console.WriteLine($"I am saving data from SQLDataAccess database");
			}
		}

    }
}
