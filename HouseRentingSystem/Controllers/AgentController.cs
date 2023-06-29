using HouseRentingSystem.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService agentService)
        {
            this.agentService = agentService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            bool isAgent = await agentService.ExistByIdAsync(userId);

            if (isAgent)
            {
                return BadRequest();
            }

            return View();
        }
    }
}
