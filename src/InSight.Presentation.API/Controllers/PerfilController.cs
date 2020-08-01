using InSight.Application.Models.Fornecedores;
using InSight.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private readonly FornecedorApplicationService fornecedorApplicationService;

        public PerfilController(FornecedorApplicationService fornecedorApplicationService)
        {
            this.fornecedorApplicationService = fornecedorApplicationService;
        }

        [HttpPost]
        public IActionResult Post(FornecedorCadastroModel model)
        {
            try
            {
                fornecedorApplicationService.Create(model);
                return Ok("fornecedor cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(FornecedorEdicaoModel model)
        {
            try
            {
                fornecedorApplicationService.Update(model);
                return Ok("fornecedor atualizado com sucesso.");
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
                var model = new FornecedorExclusaoModel() { Id = id };

                fornecedorApplicationService.Delete(model);
                return Ok("fornecedor excluído com sucesso.");
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
                return Ok(fornecedorApplicationService.GetAll());
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
                return Ok(fornecedorApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

