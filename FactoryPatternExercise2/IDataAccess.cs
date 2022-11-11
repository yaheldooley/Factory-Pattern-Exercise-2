namespace FactoryPatternExercise2
{
	public partial class Program
    {
		public interface IDataAccess
        {
            public List<Product> LoadData();
            public void SaveData();
        }

    }
}
