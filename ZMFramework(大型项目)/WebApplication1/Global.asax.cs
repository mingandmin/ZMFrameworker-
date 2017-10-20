using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;
using WebApplication1.App_Start;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //第一： 在网站一启动的时候就初始化AutoFac的相关功能  
            /* 
             1.0 告诉AutoFac初始化数据仓储层 ZM.CMS.Repository.dll中所有类的对象实例。这些对象实例以其接口的形式保存在AutoFac容器中 
             2.0 告诉AutoFac初始化业务逻辑层 ZM.CMS.Services.dll中所有类的对象实例。这些对象实例以其接口的形式保存在AutoFac容器中 
             3.0 将MVC默认的控制器工厂替换成AutoFac的工厂 
             */

            //具体做法就是我们去App_Start文件夹下创建一个AutoFacConfig类，具体实现什么功能去这个类中实现。然后再这里调用下这个类  
            AutoFacConfig.Register();


            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
       
    }
}
