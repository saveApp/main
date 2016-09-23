using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace PassingData
{
    public class CalculationModel
    {
		[JsonProperty("datenow")]
		public DateTime datenow { get; set; }
		[JsonProperty("money")]
        public double money { get; set; }
		[JsonProperty("datesave")]
        public DateTime datesave { get; set; }
		[JsonProperty("expense")]
		public double expense { get; set; }
		[JsonProperty("saveMoney")]
		public double saveMoney { get; set; }
		[JsonProperty("username")]
		public String username { get; set; }
	}
}
