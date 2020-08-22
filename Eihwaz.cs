using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;
using Terraria.ID;

namespace Eihwaz
{
	public class Eihwaz : Mod
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold and Platinum Bars", new int[]
			{
				ItemID.GoldBar,
				ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("Eihwaz:GoldPlatinumBar", group);
		}
	}
}
