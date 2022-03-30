using Controle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Controle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<CadastroModel> GetCadastros()
        {
            List<CadastroModel> lst = new List<CadastroModel>();
            CadastroModel cadastro = new CadastroModel();
            {

            }

            return lst;
        }
    }
}
