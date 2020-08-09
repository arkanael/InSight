using InSight.Application.DTOs;
using InSight.Application.Models.Perfils;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface IPerfilAppicationService
    {
        PerfilDTO Create(PerfilCadastroModel model);
        PerfilDTO Update(PerfilEdicaoModel model);
        PerfilDTO Delete(PerfilExclusaoModel model);
        List<PerfilDTO> GetAll();
        PerfilDTO GetById(string id);
    }
}
