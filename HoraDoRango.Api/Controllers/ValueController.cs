using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HoraDoRango.Api.Controllers
{
    [RoutePrefix("api")]
    public class ValueController : ApiController
    {
        /// <summary>
        /// "Função para teste."
        /// </summary>
        /// <param name="name"></param>
        /// <returns>"Retorna um teste"</returns>
        [Route("course/{name}")]
        [HttpGet]
        public string GetNome(string name)
        {
            
            return name + ", Teste OK";
        }

    }
}
