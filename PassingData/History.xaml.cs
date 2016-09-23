using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
			listHistory.ItemsSource = await new CalculationService().GetCalculation(App.Username);
			//String JSONString = "[{\"id\":1,\"username\":\"dennisdarwis\",\"money\":500,\"expense\":0,\"saveMoney\":200,\"datenow\":\"2016-09-23 04:01:18\",\"datesave\":\"2016-09-30 00:00:00\"},{\"id\":2,\"username\":\"a\",\"money\":500,\"expense\":0,\"saveMoney\":100,\"datenow\":\"2016-09-23 04:09:41\",\"datesave\":\"2016-09-30 00:00:00\"}]";
			//listHistory.ItemsSource = JsonConvert.DeserializeObject<List<CalculationModel>>(JSONString);
            listHistory.ItemSelected += async (sender, e) =>
            {
                var toCalculate = new Result((e.SelectedItem as CalculationModel));
                await Navigation.PushAsync(toCalculate); 
                //DisplayAlert("Item selected!", (e.SelectedItem as NewsModel).newsContent, "hehe");
                //DisplayAlert("Item selected!", x, "hehe");
            };
        }
		protected override bool OnBackButtonPressed()
		{
			
			Navigation.InsertPageBefore(new MainPage(), this);
			return true;
		}
    }
}
