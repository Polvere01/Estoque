using Estoque.Domain.Entidades;
using Estoque.Infra.Repositorio;
using System.Collections.Generic;
using System.Web.Http;

namespace Estoque.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class HomeController : ApiController
    {
        EmpresaRepositorio _db = new EmpresaRepositorio();

        [Route(""), HttpGet]
        public List<Empresa> Index()
        {
            return _db.ListaEmpresa();
        }
    }
}