using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DIP {
	public class DBHandler {
		private IDatabase _database;

		public DBHandler(IDatabase database) {
			_database = database;
		}

		public void Connect() { _database.Connect($"Connection to {_database.Name} established");}

		public void Create(string name) { _database.Create($"Table {name} created"); }

		public void Update(string name) { _database.Update($"Table {name} updated"); }

		public void Delete(string name) { _database.Delete($"Table {name} has been deleted");}

		public void DeleteAll() { _database.DeleteAll($"All tables in {_database.Name} has been dropped"); }

	}
}
