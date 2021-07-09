using System;
using System.Collections.Generic;
using System.Text;

namespace Service_API.Interface.Common
{
    /// <summary>
    /// Method created to perform API calls in a way that can be reused and makes the code cleaner.
    /// </summary>
    public interface IApiClient
    {
        /// <summary>
        /// Performs the API call via Post passing dynamic parameters.
        /// </summary>
        /// <typeparam name="TResult">Return Data Type</typeparam>
        /// <typeparam name="TModel">Tipo de dado de entrada</typeparam>
        /// <param name="relativePath">call name</param>
        /// <param name="ModelApi">parameters</param>
        /// <returns></returns>       
        IApiResponse<TResult> ExecutaPost<TResult, TModel>(string relativePath, TModel ModelApi);
        /// <summary>
        /// It calls an API that will not return (of type void), used a lot when adding or changing data.
        /// </summary>
        /// <typeparam name="TModel">Tipo de dado de entrada</typeparam>
        /// <param name="relativePath">call name</param>
        /// <param name="ModelApi">parameters</param>
        void ExecutaPostNoResult<TModel>(string relativePath, TModel ModelApi);
        /// <summary>
        /// Performs the API call without having to send the parameters
        /// </summary>
        /// <typeparam name="TResult">Return Data Type</typeparam>
        /// <param name="relativePath">call name</param>
        /// <returns></returns>
        IApiResponse<TResult> ExecutaPostNoParam<TResult>(string relativePath);
        /// <summary>
        /// Performs the API call without having to send the parameters
        /// </summary>
        /// <typeparam name="TResult">Return Data Type</typeparam>
        /// <param name="relativePath">call name</param>
        /// <returns></returns>
        IApiResponse<TResult> ExecutaGetNoParam<TResult>(string relativePath);
        void ExecutaPutNoResult<TModel>(string relativePath, TModel ModelApi);
        void ExecutaDeleteNoResult(string relativePath);
    }
}
