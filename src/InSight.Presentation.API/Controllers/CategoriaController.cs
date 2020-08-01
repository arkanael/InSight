using InSight.Application.Contracts;
using InSight.Application.Models.Categorias;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        //atributo
        private readonly ICategoriaApplicationService categoriaApplicationService;

        //construtor para injeção de dependência
        public CategoriaController(ICategoriaApplicationService categoriaApplicationService)
        {
            this.categoriaApplicationService = categoriaApplicationService;
        }

        [HttpPost]
        public IActionResult Post(CategoriaCadastroModel model)
        {
            try
            {
                categoriaApplicationService.Create(model);
                return Ok("Categoria cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(CategoriaEdicaoModel model)
        {
            try
            {
                categoriaApplicationService.Update(model);
                return Ok("Categoria atualizado com sucesso.");
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
                var model = new CategoriaExclusaoModel() { Id = id };

                categoriaApplicationService.Delete(model);
                return Ok("Categoria excluído com sucesso.");
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
                return Ok(categoriaApplicationService.GetAll());
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
                return Ok(categoriaApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

