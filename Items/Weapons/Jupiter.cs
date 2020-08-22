using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Eihwaz.Projectiles;

namespace Eihwaz.Items.Weapons
{
    public class Jupiter : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 110;
            item.melee = true;

            item.width = 62;
            item.height = 66;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.value = 10000;
            item.rare = ItemRarityID.Yellow;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ProjectileID.Starfury;
            item.shootSpeed = 40;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Eihwaz:GoldPlatinumBar", 8);
            recipe.AddIngredient(ModContent.ItemType<BalanceIngot>(), 9);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}