using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	internal class Program
	{
		static TableServers host1List = TableServers.GetTableServers();
		static TableServers host2List = TableServers.GetTableServers();

		static void Main(string[] args)
		{
			TableServers tableServers = TableServers.GetTableServers();
			for (int i = 0; i < 5; i++)
			{
				HostOneGetNextServer();
				HostTwoGetNextServer();
			}
			Console.ReadLine();
		}
		private static void HostOneGetNextServer()
		{
			Console.WriteLine("The Server Is   :  " + host1List.GetNextServer());
		}
		private static void HostTwoGetNextServer()
		{
			Console.WriteLine("The Server Is   :  " + host2List.GetNextServer());
		}
	}
}
