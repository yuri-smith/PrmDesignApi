using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace PrmDesignApi
{
    //https://habrahabr.ru/company/trinion/blog/296718/-хорошая статья про складской учет
    //http://www.sql.ru/forum/1032058-1/shema-sklada-dayte-sovet - схема данных склада
    //http://glavkniga.ru/elver/2012/19/887-pochemu_postavke_inogda_nedostatochno_scheta_oplatu_nuzhen_dogovor.html - договор по выставленному счету
    //https://docs.microsoft.com/ru-ru/aspnet/core/mvc/controllers/routing - маршрутизация
    //http://qaru.site/questions/13573/authentication-approach-to-be-use-in-aspnet-web-api-and-angular-js - авторизация
    //https://gist.github.com/zmts/802dc9c3510d79fd40f9dc38a12bccfc - токен-авторизация
    //https://metanit.com/sharp/aspnet5/23.7.php - JWT-токены
    //http://jasonwatmore.com/post/2016/08/16/angular-2-jwt-authentication-example-tutorial
    //https://www.testfirm.ru/api.php веб-сервис организаций (ИНН, Name)
    //http://qaru.site/questions/99465/how-to-add-and-get-header-values-in-webapi - прочитать значения из токена
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
