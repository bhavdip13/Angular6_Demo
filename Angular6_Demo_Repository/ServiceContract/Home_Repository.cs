using Angular6_Demo_Model;
using Angular6_Demo_Model.Model;
using Angular6_Demo_Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular6_Demo_Repository.ServiceContract
{
	public class Home_Repository : IHome_Repository
	{
		private Angular6_DemoEntities context;
		public Home_Repository(Angular6_DemoEntities _context)
		{
			this.context = _context;
		}
		//start your repository code hear
		//now get list of table hear for demo purpose.
		public List<Demo> GetDemoTableData()
		{
			return context.Demoes.ToList();
		}


		private bool disposed = false;
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					context.Dispose();
				}
			}
			this.disposed = true;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
