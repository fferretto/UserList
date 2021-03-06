using Newtonsoft.Json;
using Service_API.Interface.Common;
using System.Collections.Generic;
using System.Net.Http;

namespace Service_API.Service
{
    public class ApiResponse<TResult> : IApiResponse<TResult>
    {
        public ApiResponse(HttpResponseMessage response)
        {
            _response = response;
            Success = response.ReasonPhrase == "OK";

            Result = Success ? GetValue() : default(TResult);
            isValidationError = ValidationError();

            if (!Success)
                GetErrors();
        }

        private HttpResponseMessage _response;

        private TResult GetValue()
        {
            var json = _response.Content.ReadAsStringAsync().Result;
            var rawApiResult = JsonConvert.DeserializeObject<TResult>(json);

            var jArray = rawApiResult as Newtonsoft.Json.Linq.JArray;

            if (rawApiResult == null || (jArray != null && !jArray.HasValues))
                return default(TResult);

            return rawApiResult;
        }

        private void GetErrors()
        {
            var json = _response.Content.ReadAsStringAsync().Result;
            var error = JsonConvert.DeserializeObject<ApiError>(json);
            Errors = error.Details;
            MoreInfo = error.MoreInfo;
        }
        private bool ValidationError()
        {
            var json = _response.Content.ReadAsStringAsync().Result;
            var error = JsonConvert.DeserializeObject<ApiError>(json);

            return (error.Status == 409);
        }

        public bool Success { get; }
        public TResult Result { get; }
        public bool isValidationError { get; }
        public IEnumerable<string> Errors { get; private set; }
        public string MoreInfo { get; private set; }
    }

    internal class ApiError
    {
        public int Status { get; set; }
        public IEnumerable<string> Details { get; set; }
        public string MoreInfo { get; set; }
    }

    internal class RawApiResult
    {
        public int Status { get; set; }
        public object results { get; set; }
    }

    internal class ApiResult<TResult>
    {
        public int Status { get; set; }
        public TResult results { get; set; }
    }
}
