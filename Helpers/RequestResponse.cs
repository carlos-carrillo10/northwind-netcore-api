using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public class RequestResponse
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }

        public RequestResponse()
        {

        }

        public RequestResponse(Exception ex)
        {
            Success = false;
            ErrorMessage = ex.Message;
            StackTrace = ex.StackTrace;
        }

        public RequestResponse(bool success)
        {
            Success = success;
        }

        public RequestResponse(bool success, string errorMessage)
        {
            Success = success;
            ErrorMessage = errorMessage;
        }

    }

    public class RequestResponse<T> : RequestResponse where T : class
    {
        public T Data { get; set; }
        public ICollection<T> DataList { get; set; }

        public int Count
        {
            get
            {
                return DataList != null ? DataList.Count : 0;
            }
        }
        public RequestResponse()
        {

        }

        public RequestResponse(Exception ex)
        {
            Success = false;
            ErrorMessage = ex.Message;
            StackTrace = ex.StackTrace;
        }

        public RequestResponse(bool success)
        {
            Success = success;
        }

        public RequestResponse(bool success, string errorMessage)
        {
            Success = success;
            ErrorMessage = errorMessage;
        }

        public RequestResponse(T data)
        {
            Success = true;
            Data = data;
        }

        public RequestResponse(ICollection<T> data)
        {
            Success = true;
            DataList = data;
        }

    }
}
