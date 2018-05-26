using Angular6_Demo_BusinessAccessLayer.Interface;
using Angular6_Demo_BusinessObjects.Common;
using Angular6_Demo_DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Angular6_Demo_BusinessAccessLayer
{
   public class CommonManager:ICommonManager
    {
		private readonly ICommonRepository _commonRepository;
		public CommonManager(ICommonRepository commonRepository)
		{
			_commonRepository = commonRepository;
		}
		public async Task<List<GetDemoDataList>> GetDemoDataList()
		{
			return await _commonRepository.GetDemoDataList();
		}
	}
}
