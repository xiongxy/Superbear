using System;
using Microsoft.AspNetCore.Builder;
using Superbear.Exception.Middleware;

namespace Superbear.Exception
{
    public static class ErrorHandlingExtensions
    {
        public static IApplicationBuilder UseErrorHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
