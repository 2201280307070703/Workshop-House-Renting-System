using HouseRentingSystem.Web.ViewModels.Home;

namespace HouseRentingSystem.Services.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<IndexViewModel>> LastThreeHousesAsync();
    }
}
