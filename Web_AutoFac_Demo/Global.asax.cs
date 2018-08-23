using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Web_AutoFac_Demo.Controllers;
using Web_AutoFac_Demo.Models;

namespace Web_AutoFac_Demo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            var builder = new ContainerBuilder();

            // 注册单个类型（如果有很多类型要注册，可以注册整个程序集）
            builder.RegisterInstance(new TaskRepository())
                   .As<ITaskRepository>();
            builder.RegisterType<TaskController>();
            builder.Register(c => new LogManager(DateTime.Now))
                   .As<ILogger>();



            var container = builder.Build();
            // 添加 AutoFac.Mvc5 AutofacDependencyResolver类
            // 把定义好的依赖注册到系统，DependencyResolver.SetResolver 为系统方法
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            #region 系统本身代码
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            #endregion

        }
    }
}
