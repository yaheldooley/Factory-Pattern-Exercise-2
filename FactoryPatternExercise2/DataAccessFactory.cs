namespace FactoryPatternExercise2
{
	public partial class Program
    {
		public class DataAccessFactory
        {
			public static IDataAccess GetDataAccessType(string databaseType)
            {
                databaseType = databaseType.Trim().ToLower();
                switch (databaseType)
                {
                    case "list":
                        return new ListDataAccess();
                    case "sql":
                        return new SQLDataAccess();
                    case "mongo":
                        return new MongoDataAccess();
                    default:
                        return null;
                }
            }

		}

    }
}
