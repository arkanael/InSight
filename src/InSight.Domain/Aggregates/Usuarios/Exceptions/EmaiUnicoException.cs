using System;

namespace InSight.Domain.Aggregates.Usuarios.Contracts.Exceptions
{
    public class EmaiUnicoException : Exception
    {
        public override string Message => "Já existe um usuário com este e-mail cadastrado.";
    }
}
