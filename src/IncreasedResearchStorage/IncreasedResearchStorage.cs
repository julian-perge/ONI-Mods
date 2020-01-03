using System;
using Harmony;
using STRINGS;

namespace IncreasedResearchStorage
{
    [HarmonyPatch(typeof(ResearchCenterConfig), "ConfigureBuildingTemplate")]
    public static class ResearchCenterConfig_ConfigureBuildingTemplate_Patch
    {
        public static void Postfix(ref UnityEngine.GameObject go)
        {
            go.AddOrGet<Storage>().capacityKg = 3750f;
            go.AddOrGet<ManualDeliveryKG>().capacity = 3750f;
            go.AddOrGet<ManualDeliveryKG>().refillMass = 500f;
            Debug.Log("[IncreasedResearchStorage] Base Research Center loaded...");
        }
    }
    [HarmonyPatch(typeof(AdvancedResearchCenterConfig), "ConfigureBuildingTemplate")]
    public static class AdvancedResearchCenterConfig_ConfigureBuildingTemplate_Patch
    {
        public static void Postfix(ref UnityEngine.GameObject go)
        {
            go.AddOrGet<Storage>().capacityKg = 3750f;
            go.AddOrGet<ManualDeliveryKG>().capacity = 3750f;
            go.AddOrGet<ManualDeliveryKG>().refillMass = 500f;
            Debug.Log("[IncreasedResearchStorage] Advanced Research Center loaded...");
        }
    }
    [HarmonyPatch(typeof(CosmicResearchCenterConfig), "ConfigureBuildingTemplate")]
    public static class CosmicResearchCenterConfig_ConfigureBuildingTemplate_Patch
    {
        public static void Postfix(ref UnityEngine.GameObject go)
        {
            go.AddOrGet<Storage>().capacityKg = 1500f;
            go.AddOrGet<ManualDeliveryKG>().capacity = 1500f;
            go.AddOrGet<ManualDeliveryKG>().refillMass = 15f;
            Debug.Log("[IncreasedResearchStorage] Cosmic Research Center loaded...");
        }
    }
}
