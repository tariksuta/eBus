using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using eBus.Model;

using Flurl;
using Flurl.Http;
using Xamarin.Forms;

namespace eBus.Mobile
{
    public class APIService
    {
        private string _route;

        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }
       
        string text = "http://localhost:64472/api";

#if DEBUG
        private static string _apiURl = "http://localhost:5000/api"; 
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiURl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(int id)
        {
            var url = $"{_apiURl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();

        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiURl}/{_route}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                return default(T);
            }




        }

        public async Task<T> Update<T>(int id, object request)
        {
            var url = $"{_apiURl}/{_route}/{id}";

            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }
    }
}
