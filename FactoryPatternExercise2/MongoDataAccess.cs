namespace FactoryPatternExercise2
{
	public partial class Program
    {
		public class MongoDataAccess : IDataAccess
		{
			public List<Product> LoadData()
			{
				Console.WriteLine($"I am reading data from Mongo Database");
				return new List<Product>();

			}

			public void SaveData()
			{
				Console.WriteLine($"I am saving data from Mongo Database");
			}
		}

    }
}
