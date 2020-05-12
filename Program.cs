using System;
using System.Linq;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace Site
{
    public static class Program
    {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper.Factory
                .CreateWeb(args)
                .AddSetting(Keys.Host, "spectresystems.se")
                .AddSetting(Keys.LinksUseHttps, true)
                .AddSetting(Constants.EditLink, ConfigureEditLink())
                .ConfigureSite("spectresystems", "website", "develop")
                .ConfigureDeployment(deployBranch: "master")
                .AddShortcode<ChildrenShortcode>("Children")
                .AddPipelines()
                .RunAsync();

        private static Config<string> ConfigureEditLink()
        {
            return Config.FromDocument((doc, ctx) =>
            {
                return string.Format("https://github.com/{0}/{1}/edit/{2}/input/{3}",
                    ctx.GetString(Constants.Site.Owner),
                    ctx.GetString(Constants.Site.Repository),
                    ctx.GetString(Constants.Site.Branch),
                    doc.Source.GetRelativeInputPath());
            });
        }
    }
}
