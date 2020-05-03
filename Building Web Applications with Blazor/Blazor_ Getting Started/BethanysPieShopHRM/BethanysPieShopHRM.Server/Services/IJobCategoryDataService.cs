using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Services
{
    public interface IJobCategoryDataService
	{
		Task<IEnumerable<JobCategory>> GetAllJobCategories();
		Task<JobCategory> GetJobCategoryById(int jobCategoryId);
	}
}
