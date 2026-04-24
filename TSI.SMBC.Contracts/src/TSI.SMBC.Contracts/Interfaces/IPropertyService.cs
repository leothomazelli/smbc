using TSI.SMBC.Contracts.Models.DTOs;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Contracts.Interfaces
{
    public interface IPropertyService
    {
        Task<WebApiResponse<PropertyDto>> Add(PropertyDto propertyDto);
        Task<WebApiResponse<PropertyDto>> Update(PropertyDto propertyDto);
        Task<WebApiResponse<PropertyDto>> Remove(PropertyDto propertyDto);
        Task<WebApiResponse<PropertyDto>> FindById(Guid? id);
    }
}
