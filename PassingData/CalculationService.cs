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
        public async Task<List<CalculationModel>> getHistory() {
            var client = new HttpClient();
            var jsonContents = await client.GetStringAsync("http://104.199.155.15/api/v2/db/_table/newsFeed?api_key=be8387a7b036ea65deb04d1a20d85e619b7e1634aa55b1cf6cc3988f130a2e81&session_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOjIsInVzZXJfaWQiOjIsImVtYWlsIjoicHVibGljQHB1YmxpYy5jb20iLCJmb3JldmVyIjp0cnVlLCJpc3MiOiJodHRwOlwvXC8xMDQuMTk5LjE1NS4xNVwvYXBpXC92MlwvdXNlclwvc2Vzc2lvbiIsImlhdCI6MTQ3MDM4MzczMCwiZXhwIjoxNTAxOTE5NzMwLCJuYmYiOjE0NzAzODM3MzAsImp0aSI6ImFlZWQ3YWRhYmI4N2I0ODBhNmIyYWRlYWM0YzQzZTU0In0.J35hKt384v25G3ylb547w0OAlJ4yYGWRxhknwm5sYhg");
            jsonContents = jsonContents.TrimEnd('}').TrimStart('{').Substring(11);
            var data = JsonConvert.DeserializeObject<List<CalculationModel>>(jsonContents);
            List<CalculationModel> list = new List<CalculationModel>();
            foreach (CalculationModel abc in data) {
                // if abc.name == app.name
                list.Add(abc);
                
            }
            return list;

        }


    }
}
