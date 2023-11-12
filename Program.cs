namespace AbstractPractice;
class Program
{
    static void Main(string[] args)
    {
        List<DataAccess> databases = new List<DataAccess>()
        {
            //This is a cool syntax I haven't used before!
            new SqlLite(),
            new SqlServer()
        };
        
        foreach (DataAccess db in databases)
        {
            db.LoadDataConnection("demo");
            db.LoadData("selet * from table");
            db.SaveData("insert into table");
        }
        
    }
}
