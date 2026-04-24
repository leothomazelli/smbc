using TSI.SMBC.Contracts.Enums;

namespace TSI.SMBC.Contracts.Utilities
{
    public class WebApiResponse<T> where T : class
    {
        public T? Data { get; set; }

        public string Message { get; set; }

        public ResponseStatus Status { get; set; }
    }
}
