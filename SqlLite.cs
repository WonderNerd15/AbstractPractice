namespace AbstractPractice
{
    public class SqlLite : DataAccess
    {
        public override void LoadData(string sql)
        {
            Console.WriteLine($"SQL Lite database {sql} has been loaded");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine($"The SQL Lite data {sql} has been saved");
        }
    }
}