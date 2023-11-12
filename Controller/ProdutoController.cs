using GerenciamentoProdutos.Context;
using GerenciamentoProdutos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoProdutos.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoContext? _context;

        public ProdutoController(ProdutoContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            if(_context.Produtos == null)
            {
                return NotFound();
            }
            return await _context.Produtos.ToListAsync();
        }

        // GET COM ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProdutos(int id)
        {
            if(_context.Produtos == null)
            {
                return NotFound();
            }
            
            var produto = await _context.Produtos.FindAsync(id);

            if(produto == null)
            {
                return NotFound();
            }

            return produto;
        }
    }
}