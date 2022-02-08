using GlobalException.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


/*
Result:

    Status
    StatusCode
    Message
    Data*/

namespace GlobalException.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Result result = new Result();

            try
            {
                await _next(context);
            }

            catch (ArgumentException e)
            {

                var response = context.Response;
                response.ContentType = "application/json";
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                result = new Result()
                {
                    Status = Result.ResultStatus.warning,
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = e.Message
                    /*Data*/
                     
                   
                };
            }
            catch (MethodAccessException e)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                response.StatusCode = (int)HttpStatusCode.NotModified;
                result = new Result()
                {
                    Status = Result.ResultStatus.warning,
                    StatusCode = (int)HttpStatusCode.NotModified,
                    Message = e.Message
                };
            }
            catch (UnauthorizedAccessException e)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                result = new Result()
                {
                    Status = Result.ResultStatus.warning,
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = e.Message
                };
            }
            catch (Exception e)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                result = new Result()
                {
                    Status = Result.ResultStatus.warning,
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = e.Message,
                };
            }
            finally
            {
                var errorJson = JsonConvert.SerializeObject(result);
                await context.Response.WriteAsync(errorJson);
            }
        }
    }
}
