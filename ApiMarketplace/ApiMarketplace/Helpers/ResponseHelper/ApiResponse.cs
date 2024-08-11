namespace ApiMarketplace.Helpers.ResponseHelper
{
    public class ApiResponse
    {
        public int StatusCode { get; }
        public string Message { get; }
        public object[] Data { get; }

        public ApiResponse(int statusCode, string message, object[]? data = null)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data?? Array.Empty<object>();
        }
    }
}
