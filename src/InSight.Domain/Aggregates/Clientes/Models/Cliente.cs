using InSight.Domain.Aggregates.Bases.Models;
using System;

namespace InSight.Domain.Aggregates.Clientes.Models
{
    public class Cliente : BaseEnity<Cliente>
    {
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
