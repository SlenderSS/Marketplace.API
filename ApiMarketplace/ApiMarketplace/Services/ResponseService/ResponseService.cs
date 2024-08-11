using ApiMarketplace.Helpers.ResponseHelper;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Services.ResponseService
{
    public class ResponseService : IResponseService
    {
        public IActionResult CreateBadRequestResponse(string message = "Bad request")
        {
            return new BadRequestObjectResult(new ApiResponse(400, message));
        }

        public IActionResult CreateErrorResponse(string errorMessage, int statusCode = 400)
        {
            return new ObjectResult(new ApiResponse(statusCode, errorMessage)) { StatusCode = statusCode };
        }

        public IActionResult CreateForbiddenResponse(string message = "Forbidden")
        {
            return new ObjectResult(new ApiResponse(403, message)) { StatusCode = 403 };
        }

        public IActionResult CreateInternalServerErrorResponse(string message = "Internal server error")
        {
            return new ObjectResult(new ApiResponse(500, message)) { StatusCode = 500 };
        }

        public IActionResult CreateNotFoundResponse(string message = "Resource not found")
        {
            return new NotFoundObjectResult(new ApiResponse(404, message));
        }

        public IActionResult CreateResponse(int statusCode, string message, object[]? data = null)
        {
            return new ObjectResult(new ApiResponse(statusCode, message, data)) { StatusCode = statusCode };
        }

        public IActionResult CreateSuccessResponse(object[]? data, string message = "Success")
        {
            return new OkObjectResult(new ApiResponse(200, message, data));
        }

        public IActionResult CreateUnauthorizedResponse(string message = "Unauthorized access")
        {
            return new UnauthorizedObjectResult(new ApiResponse(401, message));
        }
    }
}
