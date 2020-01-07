using Harmony;
using IncreasedResearchStorage;
using UnityEngine;

namespace JulianPerge.IncreasedResearchStorage.Patches
{
		[HarmonyPatch(typeof(ResearchCenterConfig), "ConfigureBuildingTemplate")]
		public static class ResearchCenterConfig_ConfigureBuildingTemplate_Patch
		{
				public static void Postfix(ref GameObject go)
				{
						go.AddOrGet<Storage>().capacityKg = Options.Opts.BaseCapacity;
						go.AddOrGet<ManualDeliveryKG>().capacity = Options.Opts.BaseCapacity;
						go.AddOrGet<ManualDeliveryKG>().refillMass = Options.Opts.BaseRefill;
				}
		}
}