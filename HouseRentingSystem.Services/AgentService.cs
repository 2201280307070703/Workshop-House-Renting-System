using HouseRentingSystem.Data;
using HouseRentingSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Services
{
    public class AgentService : IAgentService
    {
        private readonly HouseRentingDbContext dbContext;

        public AgentService(HouseRentingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> ExistByIdAsync(string agentId)
        {
            return await dbContext.Agents.AnyAsync(a=>a.UserId.ToString() == agentId);
        }
    }
}
