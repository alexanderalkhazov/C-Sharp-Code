using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class TableServers
	{
		private static readonly TableServers _instance = new TableServers();
		private List<string> _servers= new List<string>();
		private int nextServer = 0;

		private TableServers()
		{
			_servers.Add("Tim");
			_servers.Add("Sue");
			_servers.Add("Marry");
			_servers.Add("Bob");
		}

		public static TableServers GetTableServers()
		{
			return _instance;
		}

		public string GetNextServer()
		{
			if (nextServer >= _servers.Count)
			{
				nextServer = 0;
			}
			var res = _servers[nextServer];
			nextServer++;
			return res;		
		}
	}
}
