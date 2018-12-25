using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Npgsql;
namespace WebApplication2
{
    public class IpLoc
    {
        RequestDelegate _next;
        public IpLoc(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
			
			context.Response.ContentType = "text/html;charset=utf-8";
            string path = context.Request.Path.Value.ToString();
            var ipAdressClientRequest = context.Request.Query["ip"];
            var ipAdressClientRequestFrom = "none";//comment /v2
            if (path == "/location/")
            {

                await context.Response.WriteAsync($"<h4>Вы запросили местоположение для IP: {ipAdressClientRequest} </h4>");
                await context.Response.WriteAsync($"<h4>Этот IP находится: {ipAdressClientRequestFrom} </h4>");
            }
            else
            {

                await context.Response.WriteAsync("<h3>Обращайтесь по пути /location/?ip=127.0.0.1 чтоб проверить местоположение данного IP </h3>");

            }
        }
    }
}
