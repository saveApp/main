using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PassingData
{
    public partial class History : ContentPage
    {
        public History()
        {
            InitializeComponent();

        }
        protected async override void OnAppearing()
        {
            listHistory.ItemsSource = await new CalculationService().getHistory();
            listHistory.ItemSelected += async (sender, e) =>
            {
                var toCalculate = new Result((e.SelectedItem as CalculationModel));
                await Navigation.PushAsync(toCalculate); ;
                //DisplayAlert("Item selected!", (e.SelectedItem as NewsModel).newsContent, "hehe");
                //DisplayAlert("Item selected!", x, "hehe");
            };
        }
    }
}
