using TSI.SMBC.Contracts.Models.DTOs;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Contracts.Interfaces
{
    public interface IConstructionService
    {
        Task<WebApiResponse<ConstructionDto>> Add(ConstructionDto constructionDto);
        Task<WebApiResponse<ConstructionDto>> Update(ConstructionDto constructionDto);
        Task<WebApiResponse<ConstructionDto>> Remove(ConstructionDto constructionDto);
        Task<WebApiResponse<ConstructionDto>> FindById(Guid? id);
    }
}
