using InSight.Application.Contracts;
using InSight.Application.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        //atributo
        private readonly IUsuarioApplicationService UsuarioApplicationService;

        //construtor para injeção de dependência
        public UsuariosController(IUsuarioApplicationService UsuarioApplicationService)
        {
            this.UsuarioApplicationService = UsuarioApplicationService;
        }

        [HttpPost]
        public IActionResult Post(UsuarioCadastroModel model)
        {
            try
            {
                var result = UsuarioApplicationService.Create(model);

                return Ok(new
                {
                    Message = "Usuario cadastrado com sucesso.",
                    Usuario = result
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(UsuarioEdicaoModel model)
        {
            try
            {
                var result = UsuarioApplicationService.Update(model);

                return Ok(new
                {
                    Message = "Usuario atualizado com sucesso.",
                    Usuario = result
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
                var model = new UsuarioExclusaoModel() { IdUsuario = id };
                var result = UsuarioApplicationService.Delete(model);

                return Ok(new
                {
                    Message = "Usuario excluído com sucesso.",
                    Usuario = result
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
                return Ok(UsuarioApplicationService.GetAll());
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
                return Ok(UsuarioApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

