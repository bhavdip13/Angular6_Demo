using Angular6_Demo_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Angular6_Demo_DataAccessLayer.Interface
{
  public interface ICommonRepository
    {
		Task<List<GetDemoDataList>> GetDemoDataList();
	}
}
