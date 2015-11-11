using Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(WebApiStore.IdentityConfig))]
namespace WebApiStore
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}