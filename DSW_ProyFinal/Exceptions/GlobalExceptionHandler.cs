using System.Net;
using System.Text.Json;
using BadRequestException = DSW_ProyFinal.Exceptions.BadRequestException;
using KeyNotFoundException = DSW_ProyFinal.Exceptions.KeyNotFoundException;
using NotFoundException = DSW_ProyFinal.Exceptions.NotFoundException;
using UnauthorizedException = DSW_ProyFinal.Exceptions.UnauthorizedException;

namespace DSW_ProyFinal.Exceptions
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;
        public GlobalExceptionHandler(RequestDelegate _next)
        {
            this._next = _next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                
            }
        }

        public static Task HandlerExceptionAsync(HttpContext context, Exception ex)
        {
            HttpStatusCode statusCode;
            DateTime timeStamp = DateTime.Now;
            string? stackTrace;
            string message;

            var exType = ex.GetType();
            if(exType == typeof(BadRequestException))
            {
                statusCode = HttpStatusCode.BadRequest;
            }
            else if(exType == typeof(UnauthorizedException))
            {
                statusCode = HttpStatusCode.Unauthorized;
            }
            else if( exType == typeof(KeyNotFoundException))
            {
                statusCode = HttpStatusCode.Unauthorized;
            }
            else if(exType == typeof(NotFoundException))
            {
                statusCode = HttpStatusCode.NotFound;
            }
            else
            {
                statusCode = HttpStatusCode.InternalServerError;
            }

            message = ex.Message;
            stackTrace = ex.StackTrace;

            var exceptionResult = JsonSerializer.Serialize(new
            {
                error = timeStamp,
                message,
                stackTrace,
            });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            return context.Response.WriteAsync(exceptionResult);
        }
    }
}
