using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Entidades.Produtos;
using QuickBuy.Dominio.Interface.Repositorio.Produtos;
using System;
using System.Linq;

namespace QuickBuy.Web.Controllers.Produtos
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRespositorio _produtoRepositorio;

        public ProdutoController(IProdutoRespositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            try 
            {
                var produtos = _produtoRepositorio.ObterTodos();
                if (!produtos.Any())
                {
                    return NotFound("Nenhum produto localizado.");
                }

                return Ok(produtos);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                produto.Validate();
                if (!produto.IsValid())
                {
                    return BadRequest(produto.GetErrorMessages());
                }

                if(produto.Id > 0)
                {
                    _produtoRepositorio.Atualizar(produto);
                }
                else
                {
                    _produtoRepositorio.Adicionar(produto);
                }
               
                return Created("api/produto", produto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }
    }
}