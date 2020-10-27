/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Data
{
    using Microsoft.Extensions.Configuration;
    using Paysheet.Entities;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    /// <summary>
    /// Api data access
    /// </summary>
    public class ApiDAO : Base
    {
        /// <summary>
        /// Url of api
        /// </summary>
        private string urlApi;

        /// <summary>
        /// Http client
        /// </summary>
        private HttpClient HttpApiClient;

        /// <summary>
        /// Constructor of api data access
        /// </summary>
        /// <param name="configuration">Configuration interface</param>
        public ApiDAO(IConfiguration configuration) : base(configuration)
        {
            urlApi = String.Format(_configuration.GetSection("ApiSettings").GetSection("Url").Value);
            HttpApiClient = new HttpClient();
            HttpApiClient.DefaultRequestHeaders.Accept.Clear();
            HttpApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Get method api employee
        /// </summary>
        /// <returns>List of api employee</returns>
        public async Task<List<Api>> Get()
        {
            List<Api> ApiList = new List<Api>();

            using (HttpResponseMessage response = await HttpApiClient.GetAsync(urlApi))
            {
                if (response.IsSuccessStatusCode)
                {
                    ApiList = await response.Content.ReadAsAsync<List<Api>>();
                    return ApiList;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Get method api employee
        /// </summary>
        /// <returns>An api employee</returns>
        public async Task<Api> Get(int Id)
        {
            List<Api> ApiList = new List<Api>();
            Api api = new Api();
            using (HttpResponseMessage response = await HttpApiClient.GetAsync(urlApi))
            {
                if (response.IsSuccessStatusCode)
                {
                    ApiList = await response.Content.ReadAsAsync<List<Api>>();
                    api = ApiList.Find(x => x.Id == Id);
                    return api;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
