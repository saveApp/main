using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PassingData
{
	public class NewsService
	{
		public NewsService()
		{
		}

		public async Task<List<NewsModel>> GetNews()
		{
			var client = new HttpClient();
			var jsonContents = await client.GetStringAsync("http://104.199.155.15/api/v2/db/_table/newsFeed?api_key=be8387a7b036ea65deb04d1a20d85e619b7e1634aa55b1cf6cc3988f130a2e81&session_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOjIsInVzZXJfaWQiOjIsImVtYWlsIjoicHVibGljQHB1YmxpYy5jb20iLCJmb3JldmVyIjp0cnVlLCJpc3MiOiJodHRwOlwvXC8xMDQuMTk5LjE1NS4xNVwvYXBpXC92MlwvdXNlclwvc2Vzc2lvbiIsImlhdCI6MTQ3MDM4MzczMCwiZXhwIjoxNTAxOTE5NzMwLCJuYmYiOjE0NzAzODM3MzAsImp0aSI6ImFlZWQ3YWRhYmI4N2I0ODBhNmIyYWRlYWM0YzQzZTU0In0.J35hKt384v25G3ylb547w0OAlJ4yYGWRxhknwm5sYhg");
			jsonContents = jsonContents.TrimEnd('}').TrimStart('{').Substring(11);
			var news = JsonConvert.DeserializeObject<List<NewsModel>>(jsonContents);
			return news;
		}
	}
}

