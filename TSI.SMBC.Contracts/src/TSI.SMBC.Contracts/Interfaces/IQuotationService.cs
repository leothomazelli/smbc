using TSI.SMBC.Contracts.Models.DTOs;
using TSI.SMBC.Contracts.Utilities;

namespace TSI.SMBC.Contracts.Interfaces
{
    public interface IQuotationService
    {
        Task<WebApiResponse<QuotationDto>> Add(QuotationDto quotationDto);
        Task<WebApiResponse<QuotationDto>> Update(QuotationDto quotationDto);
        Task<WebApiResponse<QuotationDto>> Remove(QuotationDto quotationDto);
        Task<WebApiResponse<QuotationDto>> FindById(Guid? id);
    }
}
