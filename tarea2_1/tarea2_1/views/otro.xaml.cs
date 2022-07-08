using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
namespace tarea2_1.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class otro : ContentPage

    {
        countriesmodel model1;
        public otro(countriesmodel model)
        {
            model1 = model;
            InitializeComponent();
            loadConfiguration();

        }
        private async void loadConfiguration()
        {

            var pin = new Pin()
            {
                Type = PinType.SavedPin,
                Position = new Position(countrySelected.latlng[0], countrySelected.latlng[1]),
                Label = "Country",
                Address = countrySelected.NameCountry.official
            };

            mapa.Pins.Add(pin);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(countrySelected.latlng[0], countrySelected.latlng[1]), Distance.FromKilometers(41)));
        }
    }
}