using TSI.SMBC.Contracts.Models.DTOs;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Contracts.Interfaces
{
    public interface IMasterService
    {
        Task<WebApiResponse<MasterDto>> Add(MasterDto masterDto);
        Task<WebApiResponse<MasterDto>> Update(MasterDto masterDto);
        Task<WebApiResponse<MasterDto>> Remove(MasterDto masterDto);
        Task<WebApiResponse<MasterDto>> FindById(Guid? id);
    }
}
