using AzeLib;
using Newtonsoft.Json;
using PeterHan.PLib;
using UnityEngine;

namespace IncreasedResearchStorage
{
		[JsonObject(MemberSerialization.OptIn)]
		[PeterHan.PLib.Options.RestartRequired]
		public class Options : BaseOptions<Options>
		{
				[Option("Base Station Capacity", "How many kg of dirt the station can store. Default is 750kg. Max is 999,999kg")]
				[Limit(1, 999999)]
				[JsonProperty]
				public float BaseCapacity { get; set; }

				[Option("Base Station Refill Amount", "What capacity Dupes will refill at. Default is 150kg. Max is 999,999kg")]
				[Limit(1, 999999)]
				[JsonProperty]
				public float BaseRefill { get; set; }

				[Option("Advanced Station Capacity", "How many kg of water the station can store. Default is 750kg. Max is 999,999kg")]
				[Limit(1, 999999)]
				[JsonProperty]
				public float AdvCapacity { get; set; }

				[Option("Advanced Station Refill Amount", "What capacity Dupes will refill at. Default is 150kg. Max is 999,999kg")]
				[Limit(1, 999999)]
				[JsonProperty]
				public float AdvRefill { get; set; }

				[Option("Cosmic Station Capacity", "How many kg of data banks the station can store. Default is 300kg. Max is 999,999kg")]
				[Limit(1, 999999)]
				[JsonProperty]
				public float CosCapacity { get; set; }

				[Option("Cosmic Station Refill Amount", "What capacity Dupes will refill at. Default is 3kg. Max is 999,999kg")]
				[Limit(1, 999999)]
				[JsonProperty]
				public float CosRefill { get; set; }

				public Options()
				{
						BaseCapacity = 750f;
						BaseRefill = 150f;
						AdvCapacity = 750f;
						AdvRefill = 150f;
						CosCapacity = 300f;
						CosRefill = 3f;
				}

				public static void OnLoad()
				{
						Load();
				}
		}
}
