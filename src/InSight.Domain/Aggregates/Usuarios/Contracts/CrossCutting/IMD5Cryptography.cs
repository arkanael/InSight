namespace InSight.Domain.Aggregates.Usuarios.Contracts.CrossCutting
{
    public interface IMD5Cryptography
    {
        public string Encrypt(string value);
    }
}
