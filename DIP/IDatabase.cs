using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP {
	public interface IDatabase {
		string Name { get; set; }
		void Connect(string message);

		void Create(string message);

		void Update(string message);

		void Delete(string message);

		void DeleteAll(string message);
	}
}
