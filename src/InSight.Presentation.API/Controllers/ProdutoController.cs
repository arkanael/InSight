using InSight.Application.Contracts;
using InSight.Application.Models.Produtos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        //atributo
        private readonly IProdutoApplicationService ProdutoApplicationService;

        //construtor para injeção de dependência
        public ProdutoController(IProdutoApplicationService ProdutoApplicationService)
        {
            this.ProdutoApplicationService = ProdutoApplicationService;
        }

        [HttpPost]
        public IActionResult Post(ProdutoCadastroModel model)
        {
            try
            {
                var result = ProdutoApplicationService.Create(model);

                return Ok(new
                {
                    Message = "Produto cadastrado com sucesso.",
                    Produto = result
                });
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
                var result = ProdutoApplicationService.Update(model);

                return Ok(new
                {
                    Message = "Produto atualizado com sucesso.",
                    Produto = result
                });
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
                var result = ProdutoApplicationService.Delete(model);

                return Ok(new
                {
                    Message = "Produto excluído com sucesso.",
                    Produto = result
                });
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
                return Ok(ProdutoApplicationService.GetAll());
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
                return Ok(ProdutoApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

