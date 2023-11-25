namespace DIP {
	internal class Program {
		static void Main(string[] args) {
			IDatabase Mysql = new MySql();

			DBHandler dbh = new DBHandler(Mysql);

			dbh.Connect();
			dbh.Create("Cars");
			dbh.Update("Cars");
			dbh.Delete("Cars");
			dbh.DeleteAll();
            Console.WriteLine("\n\n");

            IDatabase Mongo = new MongoDb();

			DBHandler dbh2 = new DBHandler(Mongo);

			dbh2.Connect();
			dbh2.Create("Cities");
			dbh2.Update("Cities");
			dbh2.Delete("Cities");
			dbh2.DeleteAll();
		}
	}
}
