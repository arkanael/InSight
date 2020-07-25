using InSight.Application.DTOs;
using InSight.Application.Models.Perfils;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface IPerfilAppicationService
    {
        void Create(PerfilCadastroModel model);
        void Update(PerfilEdicaoModel model);
        void Delete(PerfilExclusaoModel model);
        List<PerfilDTO> GetAll();
        PerfilDTO GetById(string id);
    }
}
