using TSI.SMBC.Contracts.Interfaces;
using TSI.SMBC.Contracts.Models.DTOs;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Services.Services
{
    public class PropertyService : IPropertyService
    {
        public Task<WebApiResponse<PropertyDto>> Add(PropertyDto propertyDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<PropertyDto>> FindById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<PropertyDto>> Remove(PropertyDto propertyDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<PropertyDto>> Update(PropertyDto propertyDto)
        {
            throw new NotImplementedException();
        }
    }
}
