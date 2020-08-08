using Terraria.ID;
using Terraria.ModLoader;

namespace Eihwaz.Items
{
    public class BalanceIngot : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'You can feel the essence of chaos and order flow within'");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.value = 2300;
            item.rare = ItemRarityID.Yellow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<YangCrystal>());
            recipe.AddIngredient(ModContent.ItemType<YinEssence>());
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}