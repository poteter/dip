using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP {
	public class MySql : IDatabase{

		public string Name { get; set; }
		public MySql() {
			Name = "mySQL";
		}
		public void Connect(string message) { Console.WriteLine(message); }

		public void Create(string message) { Console.WriteLine(message);}

		public void Update(string message) { Console.WriteLine(message);}

		public void Delete(string message) { Console.WriteLine(message);}

		public void DeleteAll(string message) { Console.WriteLine(message);}
	}
}
