using InSight.Application.Models.Perfils;
using InSight.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        //atributo
        private readonly PerfilApplicationService PerfilApplicationService;

        public PerfilController(PerfilApplicationService perfilApplicationService)
        {
            PerfilApplicationService = perfilApplicationService;
        }

        //construtor para injeção de dependência


        [HttpPost]
        public IActionResult Post(PerfilCadastroModel model)
        {
            try
            {
                var result = PerfilApplicationService.Create(model);

                return Ok(new
                {
                    Message = "Perfil cadastrado com sucesso.",
                    Perfil = result
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(PerfilEdicaoModel model)
        {
            try
            {
                var result = PerfilApplicationService.Update(model);

                return Ok(new
                {
                    Message = "Perfil atualizado com sucesso.",
                    Perfil = result
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
                var model = new PerfilExclusaoModel() { Id = id };
                var result = PerfilApplicationService.Delete(model);

                return Ok(new
                {
                    Message = "Perfil excluído com sucesso.",
                    Perfil = result
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
                return Ok(PerfilApplicationService.GetAll());
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
                return Ok(PerfilApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

