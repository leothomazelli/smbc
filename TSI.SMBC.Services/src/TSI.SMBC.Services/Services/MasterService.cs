using TSI.SMBC.Contracts.Interfaces;
using TSI.SMBC.Contracts.Models.DTOs;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Services
{
    public class MasterService : IMasterService
    {
        public Task<WebApiResponse<MasterDto>> Add(MasterDto masterDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<MasterDto>> FindById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<MasterDto>> Remove(MasterDto masterDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<MasterDto>> Update(MasterDto masterDto)
        {
            throw new NotImplementedException();
        }
    }
}
