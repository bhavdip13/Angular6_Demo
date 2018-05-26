using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular6_Demo.Models;
using Angular6_Demo_BusinessAccessLayer.Interface;
using Angular6_Demo_BusinessObjects.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular6_Demo.Controllers
{
    [Produces("application/json")]
    
    public class HomeController : Controller
    {
		public readonly ICommonManager _commonManager;

		//IHome_Repository _Home_Repository = new Home_Repository(new Angular6_DemoEntities());
		Angular6_DemoContext db = new Angular6_DemoContext();
		[Route("api/Common/GetAll_ef")]
		[HttpGet]
		public List<Demo> GetAll_ef()
		{
			return db.Demo.ToList();
		}

		public HomeController(ICommonManager commonManager)
		{
			_commonManager = commonManager;
		}

		[Route("api/Common/GetAll")]
		[HttpGet]
		public async Task<List<GetDemoDataList>> GetAll()
		{
			return await _commonManager.GetDemoDataList();
		}

	}
}