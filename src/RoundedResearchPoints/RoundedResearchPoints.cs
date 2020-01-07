using Harmony;
using System;

namespace RoundedResearchPoints
{
		[HarmonyPatch(typeof(ResearchCenter), "ConvertMassToResearchPoints")]
		public static class ResearchCenter_ConvertMassToResearchPoints_Patch
		{
				public static void Prefix(ref float mass_consumed)
				{
						// Round to 2 decimals.
						mass_consumed = (float)Math.Round(mass_consumed, 2);
				}
		}
}