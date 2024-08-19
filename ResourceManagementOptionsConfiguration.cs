using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejzbolNet.MainTheme
{
    internal class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static readonly ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();


            // bootstrap css 
            _manifest
                .DefineStyle("BejzbolNet-BootstrapCss")
                .SetUrl("~/BejzbolNet.MainTheme/css/bootstrap.min.css")
                .SetCdn("https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css")
                .SetVersion("5.3.3");

            // bootstrap js 
            _manifest
                .DefineScript("BejzbolNet-BootstrapJs")
                .SetUrl("~/BejzbolNet.MainTheme/js/bootstrap.bundle.min.js")
                .SetCdn("https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js")
                .SetVersion("5.3.3");
            
            // splide css 
            _manifest
                .DefineStyle("BejzbolNet-SplideCss")
                .SetUrl("~/BejzbolNet.MainTheme/css/splide.min.css")
                .SetCdn("https://cdn.jsdelivr.net/npm/@splidejs/splide@4.1.3/dist/css/splide.min.css")
                .SetVersion("4.1.3"); 
            
            // splide js 
            _manifest
                .DefineScript("BejzbolNet-SplideJs")
                .SetUrl("~/BejzbolNet.MainTheme/js/splide.min.js")
                .SetCdn("https://cdn.jsdelivr.net/npm/@splidejs/splide@4.1.3/dist/js/splide.min.js")
                .SetVersion("4.1.3"); 
            
            // jquery js 
            _manifest
                .DefineScript("BejzbolNet-JqueryJs")
                .SetUrl("~/BejzbolNet.MainTheme/js/jquery-3.7.1.min.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js")
                .SetVersion("3.7.1");
            
            // activate links js 
            _manifest
                .DefineScript("BejzbolNet-ActivateLinksJs")
                .SetUrl("~/OrchardCore.Menu/Scripts/activate-links.min.js")
                .SetVersion("1.0.0")
                .SetDependencies(new []{ "BejzbolNet-JqueryJs"});

            // custom style css //
            _manifest
                .DefineStyle("BejzbolNet-CustomCss")
                .SetUrl("~/BejzbolNet.MainTheme/css/site.css", "~/BejzbolNet.MainTheme/css/site.css")
                .SetVersion("1.0.0");
            
            _manifest
                .DefineResource("image","BejzbolNet-Logo")
                .SetUrl("~/BejzbolNet.MainTheme/images/bejzbol-net-logo-white-shadow.png", "~/BejzbolNet.MainTheme/images/bejzbol-net-logo-white-shadow.png")
                .SetVersion("1.0.0");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}
