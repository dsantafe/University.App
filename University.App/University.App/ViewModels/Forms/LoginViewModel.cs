﻿using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace University.App.ViewModels.Forms
{
    public class LoginViewModel
    {
        private string _email;
        private string _password;

        async void Login()
        {
            var data = new { email = _email, password = _password };
            var json = JsonConvert.SerializeObject(data);
            var req = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://reqres.in/api/login";
            var result = string.Empty;

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, req);

                if (response.IsSuccessStatusCode)
                {
                    //TODO: Logic App
                    await Application.Current.MainPage.DisplayAlert("Notify", "Login OK", "Cancel");
                }

                var statusCode = response.StatusCode;
                result = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
