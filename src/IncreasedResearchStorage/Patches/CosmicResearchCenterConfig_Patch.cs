using Harmony;
using IncreasedResearchStorage;
using UnityEngine;

namespace JulianPerge.IncreasedResearchStorage.Patches
{
		[HarmonyPatch(typeof(CosmicResearchCenterConfig), "ConfigureBuildingTemplate")]
		public static class CosmicResearchCenterConfig_ConfigureBuildingTemplate_Patch
		{
				public static void Postfix(ref GameObject go)
				{
						go.AddOrGet<Storage>().capacityKg = Options.Opts.CosCapacity;
						go.AddOrGet<ManualDeliveryKG>().capacity = Options.Opts.CosCapacity;
						go.AddOrGet<ManualDeliveryKG>().refillMass = Options.Opts.CosRefill;
				}
		}
}