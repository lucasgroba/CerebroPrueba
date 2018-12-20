﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebPresentation.Startup))]
namespace WebPresentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
