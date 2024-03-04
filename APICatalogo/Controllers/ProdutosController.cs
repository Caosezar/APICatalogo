using APICatalogo.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Platform.Util.Resourcer;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProdutosController (AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Produtos> Get()
        {
            var Produtos = _context.Produtos.ToList();
        }
    }
}
