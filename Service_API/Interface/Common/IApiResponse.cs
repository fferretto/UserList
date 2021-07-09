using System;
using System.Collections.Generic;
using System.Text;

namespace Service_API.Interface.Common
{
    public interface IApiResponse<TResult>
    {
        bool Success { get; }
        TResult Result { get; }
        IEnumerable<string> Errors { get; }
        string MoreInfo { get; }
    }
}
