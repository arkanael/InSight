
using InSight.Application.Contracts;
using InSight.Application.Models.Clientes;
using InSight.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class clienteesController : ControllerBase
    {
        //atributo
        private ClienteApplicationService clienteApplicationService;

        public clienteesController(ClienteApplicationService clienteApplicationService)
        {
            this.clienteApplicationService = clienteApplicationService;
        }

        //construtor para injeção de dependência

        [HttpPost]
        public IActionResult Post(ClienteCadastroModel model)
        {
            try
            {
                var result = clienteApplicationService.Create(model);

                return Ok(new
                {
                    Message = "cliente cadastrado com sucesso.",
                    cliente = result
                });
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
                var result = clienteApplicationService.Update(model);

                return Ok(new
                {
                    Message = "cliente atualizado com sucesso.",
                    cliente = result
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
                var model = new ClienteExclusaoModel() { Id = id };

                var result = clienteApplicationService.Delete(model);

                return Ok(new
                {
                    Message = "cliente excluído com sucesso.",
                    cliente = result
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