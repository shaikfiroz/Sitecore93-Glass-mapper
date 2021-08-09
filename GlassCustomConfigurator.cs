using Devpracticesc93.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Devpracticesc93
{
	public class GlassCustomConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<ArticleController>();
			serviceCollection.AddTransient<PracticeController>();
		}
	}
}