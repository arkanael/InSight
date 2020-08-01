using InSight.Application.Contracts;
using InSight.Application.Models.Produtos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        //atributo
        private IProdutoApplicationService produtoApplicationService;

        //construtor para injeção de dependência
        public ProdutosController(IProdutoApplicationService produtoApplicationService)
        {
            this.produtoApplicationService = produtoApplicationService;
        }

        [HttpPost]
        public IActionResult Post(ProdutoCadastroModel model)
        {
            try
            {
                produtoApplicationService.Create(model);
                return Ok("Produto cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(ProdutoEdicaoModel model)
        {
            try
            {
                produtoApplicationService.Update(model);
                return Ok("Produto atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var model = new ProdutoExclusaoModel() { Id = id };

                produtoApplicationService.Delete(model);
                return Ok("Produto excluído com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(produtoApplicationService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                return Ok(produtoApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}