using InSight.Application.Models.Clientes;
using InSight.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteApplicationService clienteApplicationService;

        public ClienteController(ClienteApplicationService clienteApplicationService)
        {
            this.clienteApplicationService = clienteApplicationService;
        }

        [HttpPost]
        public IActionResult Post(ClienteCadastroModel model)
        {
            try
            {
                clienteApplicationService.Create(model);
                return Ok("cliente cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(ClienteEdicaoModel model)
        {
            try
            {
                clienteApplicationService.Update(model);
                return Ok("cliente atualizado com sucesso.");
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
                var model = new ClienteExclusaoModel() { Id = id };

                clienteApplicationService.Delete(model);
                return Ok("cliente excluído com sucesso.");
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
                return Ok(clienteApplicationService.GetAll());
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
                return Ok(clienteApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

