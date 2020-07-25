using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InSight.Application.Models.Perfils
{
    public class PerfilExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id do perfil.")]
        public string Id { get; set; }
    }
}
