namespace AbstractPractice
{
    public abstract class DataAccess
    {
        //Method to be inherited with business logic
        public string LoadDataConnection(string name)
        {
            Console.WriteLine($"The database {name} has been loaded");
            return name;
        }

        //Abstract methods to be overriden in the child class
        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }
}