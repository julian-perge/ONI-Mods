using Harmony;
using UnityEngine;
using PeterHan.PLib;

namespace IncreasedResearchStorage
{

		[HarmonyPatch(typeof(ResearchCenterConfig), "ConfigureBuildingTemplate")]
		public static class ResearchCenterConfig_ConfigureBuildingTemplate_Patch
		{
				public static void Postfix(ref GameObject go)
				{
						go.AddOrGet<Storage>().capacityKg = Options.Opts.BaseCapacity;
						go.AddOrGet<ManualDeliveryKG>().capacity = Options.Opts.BaseCapacity;
						go.AddOrGet<ManualDeliveryKG>().refillMass = Options.Opts.BaseRefill;
						Debug.Log("[IncreasedResearchStorage] Base Research Center loaded...");
				}
		}
		[HarmonyPatch(typeof(AdvancedResearchCenterConfig), "ConfigureBuildingTemplate")]
		public static class AdvancedResearchCenterConfig_ConfigureBuildingTemplate_Patch
		{
				public static void Postfix(ref GameObject go)
				{
						go.AddOrGet<Storage>().capacityKg = Options.Opts.AdvCapacity;
						go.AddOrGet<ManualDeliveryKG>().capacity = Options.Opts.AdvCapacity;
						go.AddOrGet<ManualDeliveryKG>().refillMass = Options.Opts.AdvRefill;
						Debug.Log("[IncreasedResearchStorage] Advanced Research Center loaded...");
				}
		}
		[HarmonyPatch(typeof(CosmicResearchCenterConfig), "ConfigureBuildingTemplate")]
		public static class CosmicResearchCenterConfig_ConfigureBuildingTemplate_Patch
		{
				public static void Postfix(ref GameObject go)
				{
						go.AddOrGet<Storage>().capacityKg = Options.Opts.CosCapacity;
						go.AddOrGet<ManualDeliveryKG>().capacity = Options.Opts.CosCapacity;
						go.AddOrGet<ManualDeliveryKG>().refillMass = Options.Opts.CosRefill;
						Debug.Log("[IncreasedResearchStorage] Cosmic Research Center loaded...");
				}
		}
}
