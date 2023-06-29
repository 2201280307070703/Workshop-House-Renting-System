using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HouseRentingSystem.Web.Infrastructure.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? assembly = Assembly.GetAssembly(serviceType);

            if (assembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            Type[] implementationTypes=assembly.GetTypes()
                .Where(t=>t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (var implementationType in implementationTypes)
            {
                Type? interfaceType = implementationType
                    .GetInterface($"I{implementationType.Name}");

                if(interfaceType== null)
                {
                    throw new InvalidOperationException("No interface is provided with this service name!");
                }

                services.AddScoped(interfaceType, implementationType);
            }
        }
    }
}
