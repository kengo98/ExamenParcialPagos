using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Parcial2.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Helpers
{
    public class ApiService
    {
        public async Task<List<T>> POST<T>(string urlBase, string servicePrefix, string controller, T content)
        {
            try
            {
                var client = new HttpClient();
                var url = string.Format("{0}{1}", servicePrefix, controller);
                client.BaseAddress = new Uri(urlBase);
                var json = JsonConvert.SerializeObject(content);
                HttpContent cont = new StringContent(json);
                cont.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(url, cont);
                return null;
            }
            catch(Exception e)
            {
                return null;
            }
        }


        public async Task<List<T>> Get<T>(string urlBase,string servicePrefix,string controller)
        {
            try
            {
                var client = new HttpClient();
                var url = string.Format("{0}{1}", servicePrefix, controller);
                client.BaseAddress = new Uri(urlBase);
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<T>> PUT<T>(string urlBase, string servicePrefix, string controller)
        {
            try
            {
                var client = new HttpClient();
                var url = string.Format("{0}{1}", servicePrefix, controller);
                client.BaseAddress = new Uri(urlBase);
                var response = await client.PutAsync(url, new StringContent(JsonConvert.SerializeObject(""), Encoding.UTF8));
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<T>> DELETE<T>(string urlBase, string servicePrefix, string controller)
        {
            try
            {
                var client = new HttpClient();
                var url = string.Format("{0}{1}", servicePrefix, controller);
                client.BaseAddress = new Uri(urlBase);
                var response = await client.DeleteAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch
            {
                return null;
            }
        }

    }
}
