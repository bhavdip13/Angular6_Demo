using Dapper;
using Angular6_Demo_DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Angular6_Demo_BusinessObjects.Common;
using Angular6_Demo_BusinessObjects.Settings;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Angular6_Demo_DataAccessLayer
{
	public class CommonRepository : ICommonRepository
    {
		private readonly DbSettings _settings;
		public CommonRepository(IOptions<DbSettings> options)
		{
			_settings = options.Value;
		}
		public async Task<List<GetDemoDataList>> GetDemoDataList()
		{
			try
			{
				using (var dbConnection = new SqlConnection(_settings.ConnectionString[DbConnections.DbContext.ToString()]))
			  {
					//dbConnection.Open();
					return (await dbConnection.QueryAsync<GetDemoDataList>("SELECT [Id],[Name] FROM [dbo].[Demo]", null)).ToList();
				}
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
