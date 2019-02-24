using System.Web.Http;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None; // (IPC) Utilizando "None", para remover os "$Id" adicionados pelo Entity Framework, retornando assim comente o resultado real do banco
            config.Formatters.Remove(config.Formatters.XmlFormatter);// (IPC) Utilizado pra remover o retorno xlm do serviço passando a utilizar o Json

            // Web API routes
            config.EnableCors();// (IPC) Usado para permitir requisições de outras urls

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",//Formato da rota
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
