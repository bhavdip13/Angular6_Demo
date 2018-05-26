using Angular6_Demo_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular6_Demo_Repository.Service
{
	public interface IHome_Repository : IDisposable
	{
		List<Demo> GetDemoTableData();
	}
}
