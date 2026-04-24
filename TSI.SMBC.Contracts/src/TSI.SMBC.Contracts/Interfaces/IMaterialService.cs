using TSI.SMBC.Contracts.Models;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Contracts.Interfaces
{
    public interface IMaterialService
    {
        Task<WebApiResponse<MaterialDto>> Add(MaterialDto materialDto);
        Task<WebApiResponse<MaterialDto>> Update(MaterialDto materialDto);
        Task<WebApiResponse<MaterialDto>> Remove(MaterialDto materialDto);
        Task<WebApiResponse<MaterialDto>> FindById(Guid? id);
    }
}
