using Harmony;
using System.Collections.Generic;
using UnityEngine;

namespace MoreRockCrusherOptions
{
		[HarmonyPatch(typeof(RockCrusherConfig), "ConfigureBuildingTemplate")]
		public class AbyssaliteAluminumOre
		{
				public static void Postfix(ref GameObject go)
				{
						ComplexRecipe.RecipeElement[] ingredients = new ComplexRecipe.RecipeElement[1]
								{
										new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Katairite).tag, 100f)
								};

						ComplexRecipe.RecipeElement[] results = new ComplexRecipe.RecipeElement[2]
						{
										new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.AluminumOre).tag, 50f),
										new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Sand).tag, 50f)
						};

						new ComplexRecipe(
								ComplexRecipeManager.MakeRecipeID(
										"RockCrusher"
										, (IList<ComplexRecipe.RecipeElement>)ingredients
										, (IList<ComplexRecipe.RecipeElement>)results)
										, ingredients, results
								)
						{
								time = 40f,
								description = string.Format((string)STRINGS.BUILDINGS.PREFABS.ROCKCRUSHER.LIME_FROM_LIMESTONE_RECIPE_DESCRIPTION, (object)SimHashes.Katairite.CreateTag().ProperName(), (object)SimHashes.Wolframite.CreateTag().ProperName(), (object)SimHashes.Sand.CreateTag().ProperName()),
								nameDisplay = ComplexRecipe.RecipeNameDisplay.IngredientToResult
						}.fabricators = new List<Tag>()
						{
								TagManager.Create("RockCrusher")
						};
				}
		}
}