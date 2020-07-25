﻿using System;

namespace InSight.Application.DTOs
{
    public class ClienteDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
