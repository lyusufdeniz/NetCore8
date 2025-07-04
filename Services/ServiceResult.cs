using System.Net;

namespace App.Services
{
    public class ServiceResult<T>
    {
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }

        public bool IsSucces => Errors == null || Errors.Count == 0;
        public HttpStatusCode StatusCode { get; set; }
        public static ServiceResult<T> Succes(T? data,HttpStatusCode statusCode=HttpStatusCode.OK)=> new ServiceResult<T>(){Data = data,StatusCode=statusCode};

        public static ServiceResult<T> Fail(List<string>? errors,HttpStatusCode statusCode=HttpStatusCode.BadRequest)=> new ServiceResult<T>(){ Errors = errors, StatusCode = statusCode };

        public static ServiceResult<T> Fail(string error,HttpStatusCode statusCode=HttpStatusCode.BadRequest)=> new ServiceResult<T>(){Errors = new List<string> { error }, StatusCode = statusCode };

    }
}
