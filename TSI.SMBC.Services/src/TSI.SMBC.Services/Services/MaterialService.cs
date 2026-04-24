using TSI.SMBC.Contracts.Interfaces;
using TSI.SMBC.Contracts.Models;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Services
{
    public class MaterialService : IMaterialService
    {
        public Task<WebApiResponse<MaterialDto>> Add(MaterialDto materialDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<MaterialDto>> FindById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<MaterialDto>> Remove(MaterialDto materialDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<MaterialDto>> Update(MaterialDto materialDto)
        {
            throw new NotImplementedException();
        }
    }
}
