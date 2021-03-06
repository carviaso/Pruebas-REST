﻿using Banking.App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        private HttpClient client;
        private List<Banking_User> items;

        public MainPage()
        {
            InitializeComponent();

            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.BankingBackendUrl}/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            items = new List<Banking_User>();
            btnLogin.Clicked += BtnLogin_ClickedAsync;
        }

        private async void BtnLogin_ClickedAsync(object sender, EventArgs e)
        {
            Auth_Login login = new Auth_Login();
            login.Email = txtUser.Text;
            login.Password = txtPass.Text;
            Debug.WriteLine(@"El valor de: $login");


            Employee employee = new Employee
            {
                FirstName = "Jalpesh",
                LastName = "Vadgama"
            };

            string jsonString = JsonConvert.SerializeObject(employee);
            Console.WriteLine(jsonString);



            var json = JsonConvert.SerializeObject(employee);
            Debug.WriteLine(@"El valor de: json");
            var context = new StringContent(json, Encoding.UTF8, "application /json");

            Debug.WriteLine(@" successfully saved.");

            //TODO: URL de Sitio es: https://bankingwebapi.azurewebsites.net/api/v1/Auth/Login
            HttpResponseMessage response = await client.PostAsync($"api/v1/Auth/Login", context);



        }

        [Serializable]
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

    }
}
