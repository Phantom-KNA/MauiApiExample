using MauiApiExample.Modelo;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace MauiApiExample;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        OnClicked(null, null);
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Load");
        var request = new HttpRequestMessage();
        request.Method = HttpMethod.Get;
        request.RequestUri = new Uri("https://gazpro.mx/gazproAPI/api/PuntosPremios");
        request.Headers.Add("Accept", "application/json");
        var client = new HttpClient();
        HttpResponseMessage response = await client.SendAsync(request);

        var clientInfo = new List<PuntosPremios>();
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var content = await response.Content.ReadAsStringAsync();
            clientInfo = JsonConvert.DeserializeObject<List<PuntosPremios>>(content);
            LstPremios.ItemsSource = clientInfo;
        }
        
    }
}

