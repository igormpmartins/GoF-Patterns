using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class BitcoinApi : CoinApi
    {
        public override decimal GetValueInUSD()
        {
			return 50.0m;

			//404, so it's not working anymore :| 
			var request = WebRequest.Create(@"http://coinabul.com/api.php");
			BitcoinResponse json = null;
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                var serializer = new DataContractJsonSerializer(typeof(BitcoinResponse));
                var obj = serializer.ReadObject(response.GetResponseStream());
                json = obj as BitcoinResponse;
            }
            return (decimal)(json != null ? json.BTC.USD : 0f);
        }

		/// <summary>
		/// The json response object of the bitcoin service.
		/// </summary>
		[DataContract]
		public class BitcoinResponse
		{
			[DataMember(Name = "BTC")]
			public BTCResponse BTC { get; set; }
		}

		/// <summary>
		/// The json BTC response object of the bitcoin service.
		/// </summary>
		[DataContract]
		public class BTCResponse
		{
			[DataMember(Name = "USD")]
			public float USD { get; set; }
		}

	}
}
