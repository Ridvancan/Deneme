using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI
{
    public static class ApıDal<T>
    {
        static string url = "https://northwind.now.sh/";
        public static async Task<List<T>> GetInfo(string s)
        {//Generic Kullanımı ile Web API den veri çekme.
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync($"api/{s}");
            string result = await response.Content.ReadAsStringAsync();
            List<T> t = JsonConvert.DeserializeObject<List<T>>(result);
            return t;
        }
    }
       
    }
