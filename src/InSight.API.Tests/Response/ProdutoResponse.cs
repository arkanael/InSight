using InSight.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.API.Tests.Response
{
    public class ProdutoResponse
    {
        public string Message { get; set; }
        public ProdutoDTO produto { get; set; }
    }
}
