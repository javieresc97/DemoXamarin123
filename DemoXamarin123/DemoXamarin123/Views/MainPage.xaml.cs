using DemoXamarin123.Model;
using System;
using Xamarin.Forms;

namespace DemoXamarin123
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MyBtn_OnClicked(object sender, EventArgs e)
        {
            var client = new AzureClient();
            await client.InsertarAsistente(
                new Asistente() { Nombre = NombreTxt.Text });
        }
    }
}