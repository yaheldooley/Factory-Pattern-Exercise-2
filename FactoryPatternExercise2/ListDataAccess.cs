namespace FactoryPatternExercise2
{
	public partial class Program
    {
		public class ListDataAccess : IDataAccess
        {
            public List<Product> LoadData()
            {
				Console.WriteLine($"I am reading data from ListDataAccess database");
				return new List<Product>();
			}

            public void SaveData()
            {
				Console.WriteLine($"I am saving data from ListDataAccess database");
			}
        }

    }
}
