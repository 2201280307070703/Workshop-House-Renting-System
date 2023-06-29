namespace HouseRentingSystem.Services.Contracts
{
    public interface IAgentService
    {
        Task<bool> ExistByIdAsync(string agentId);
    }
}
