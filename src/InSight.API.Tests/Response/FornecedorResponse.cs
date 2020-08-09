using InSight.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.API.Tests.Response
{
    public class FornecedorResponse
    {
        public string Message { get; set; }
        public FornecedorDTO fornecedor { get; set; }
    }
}
