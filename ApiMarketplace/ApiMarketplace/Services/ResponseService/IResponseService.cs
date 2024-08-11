using ApiMarketplace.Helpers.ResponseHelper;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Services.ResponseService
{
    public interface IResponseService
    {
        IActionResult CreateSuccessResponse(object[]? data, string message= "success");
        IActionResult CreateErrorResponse(string errorMessage, int statusCode = 400);
        IActionResult CreateResponse(int statusCode, string message, object[]? data = null);
        IActionResult CreateNotFoundResponse(string message = "Resource not found");
        IActionResult CreateUnauthorizedResponse(string message = "Unauthorized access");
        IActionResult CreateForbiddenResponse(string message = "Forbidden");
        IActionResult CreateBadRequestResponse(string message = "Bad request");
        IActionResult CreateInternalServerErrorResponse(string message = "Internal server error");
    }
}
