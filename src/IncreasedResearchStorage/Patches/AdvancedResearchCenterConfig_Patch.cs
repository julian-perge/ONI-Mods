using Harmony;
using IncreasedResearchStorage;
using UnityEngine;

namespace JulianPerge.IncreasedResearchStorage.Patches
{
		[HarmonyPatch(typeof(AdvancedResearchCenterConfig), "ConfigureBuildingTemplate")]
		public static class AdvancedResearchCenterConfig_ConfigureBuildingTemplate_Patch
		{
				public static void Postfix(ref GameObject go)
				{
						go.AddOrGet<Storage>().capacityKg = Options.Opts.AdvCapacity;
						go.AddOrGet<ManualDeliveryKG>().capacity = Options.Opts.AdvCapacity;
						go.AddOrGet<ManualDeliveryKG>().refillMass = Options.Opts.AdvRefill;
				}
		}
}