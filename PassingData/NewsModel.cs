using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace PassingData
{
	public class NewsModel
	{
		[JsonProperty("id")]
		public int id { get; set; }

		[JsonProperty("newsName")]
		public string newsName { get; set; }

		[JsonProperty("newsURL")]
		public string newsURL { get; set; }

		[JsonProperty("newsIMGURL")]
		public string newsIMGURL { get; set; }

		[JsonProperty("newsContent")]
		public string newsContent { get; set; }
	}
}

