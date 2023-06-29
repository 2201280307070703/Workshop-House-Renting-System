using HouseRentingSystem.Data;
using HouseRentingSystem.Services.Contracts;
using HouseRentingSystem.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Services
{
   public class HouseService : IHouseService
    {
        private readonly HouseRentingDbContext dbContext;

        public HouseService(HouseRentingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexViewModel>> LastThreeHousesAsync()
        {
            return await dbContext.Houses.OrderByDescending(d => d.CreatedOn).Take(3)
                .Select(h => new
                IndexViewModel
                {
                    Id=h.Id.ToString(),
                    Title=h.Title,
                    ImageUrl=h.ImageUrl
                }).ToListAsync();
        }
    }
}
