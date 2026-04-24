using TSI.SMBC.Contracts.Interfaces;
using TSI.SMBC.Contracts.Models.DTOs;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Services
{
    public class QuotationService : IQuotationService
    {
        public Task<WebApiResponse<QuotationDto>> Add(QuotationDto quotationDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<QuotationDto>> FindById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<QuotationDto>> Remove(QuotationDto quotationDto)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResponse<QuotationDto>> Update(QuotationDto quotationDto)
        {
            throw new NotImplementedException();
        }
    }
}
