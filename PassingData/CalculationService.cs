using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PassingData
{
    public class CalculationService
    {
        public CalculationService() { }
		public async Task<List<CalculationModel>> GetCalculation(String username)
		{
			var client = new HttpClient();
			var jsonContents = await client.GetStringAsync("http://104.199.155.15/api/v2/db/_table/calculationHistory?api_key=be8387a7b036ea65deb04d1a20d85e619b7e1634aa55b1cf6cc3988f130a2e81&session_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOjIsInVzZXJfaWQiOjIsImVtYWlsIjoicHVibGljQHB1YmxpYy5jb20iLCJmb3JldmVyIjp0cnVlLCJpc3MiOiJodHRwOlwvXC8xMDQuMTk5LjE1NS4xNVwvYXBpXC92MlwvdXNlclwvc2Vzc2lvbiIsImlhdCI6MTQ3MDM4MzczMCwiZXhwIjoxNTAxOTE5NzMwLCJuYmYiOjE0NzAzODM3MzAsImp0aSI6ImFlZWQ3YWRhYmI4N2I0ODBhNmIyYWRlYWM0YzQzZTU0In0.J35hKt384v25G3ylb547w0OAlJ4yYGWRxhknwm5sYhg&filter=username%3D"+username);
			jsonContents = jsonContents.TrimEnd('}').TrimStart('{').Substring(11);
			var calculation = JsonConvert.DeserializeObject<List<CalculationModel>>(jsonContents);
			return calculation;
		}
		public async Task<bool> Post(CalculationModel data)
		{
			bool success = false;
			var uri = new Uri("http://104.199.155.15/api/v2/db/_table/calculationHistory?api_key=be8387a7b036ea65deb04d1a20d85e619b7e1634aa55b1cf6cc3988f130a2e81&session_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOjIsInVzZXJfaWQiOjIsImVtYWlsIjoicHVibGljQHB1YmxpYy5jb20iLCJmb3JldmVyIjp0cnVlLCJpc3MiOiJodHRwOlwvXC8xMDQuMTk5LjE1NS4xNVwvYXBpXC92MlwvdXNlclwvc2Vzc2lvbiIsImlhdCI6MTQ3MDM4MzczMCwiZXhwIjoxNTAxOTE5NzMwLCJuYmYiOjE0NzAzODM3MzAsImp0aSI6ImFlZWQ3YWRhYmI4N2I0ODBhNmIyYWRlYWM0YzQzZTU0In0.J35hKt384v25G3ylb547w0OAlJ4yYGWRxhknwm5sYhg");
			var json = "{ \"resource\": [{\"datenow\": \"" + data.datenow + "\", \"datesave\":\"" + data.datesave + "\", \"expense\":\"" + data.expense + "\", \"money\":\"" + data.money+"\", \"saveMoney\":\"" + data.saveMoney+"\", \"username\":\"" + data.username+"\"}       ] }";
			//var json = "{ \"resource\": [{\"username\": \"kemalanjing\", \"password\":\"totski\", \"email\":\"lelel@gmail.com\"}       ] }";
			var client = new HttpClient();

			var content = new StringContent(json, Encoding.UTF8, "application/json");
			HttpResponseMessage response = null;
			response = await client.PostAsync(uri, content);
			if (response.IsSuccessStatusCode)
			{
				success = true;
			}
			return success;
		}

    }
}
