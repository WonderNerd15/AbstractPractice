namespace AbstractPractice
{
    public class SqlServer : DataAccess
    {
        public override void LoadData(string sql)
        {
            Console.WriteLine($"SQL Server database {sql} has been loaded");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine($"The SQL Server data {sql} has been saved");
        }
    }
}