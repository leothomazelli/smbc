using TSI.SMBC.Contracts.Interfaces;
using TSI.SMBC.Contracts.Models.DTOs;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Services
{
    public class ConstructionService : IConstructionService
    {
        public Task<WebApiResponse<ConstructionDto>> Add(ConstructionDto constructionDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<ConstructionDto>> FindById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<ConstructionDto>> Remove(ConstructionDto constructionDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<ConstructionDto>> Update(ConstructionDto constructionDto)
        {
            throw new NotImplementedException();
        }
    }
}
