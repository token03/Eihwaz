using Eihwaz.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace Eihwaz.Items.Weapons
{
    public class ArtOfWar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Rapidly shoots minature balls of energy");
        }

        public override void SetDefaults()
        {
            item.damage = 46;
            item.mana = 7;
            item.magic = true;
            item.noMelee = true;
            item.autoReuse = true;

            item.width = 40;
            item.height = 40;
            item.useTime = 10;
            item.knockBack = 4;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.value = 10000;
            item.rare = ItemRarityID.Yellow;
            item.UseSound = SoundID.Item20;
            item.shoot = mod.ProjectileType("ArtOfWarProjectile");
            item.shootSpeed = 26; 

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LightShard);
            recipe.AddIngredient(ItemID.DarkShard);
            recipe.AddIngredient(ItemID.Book);
            recipe.AddIngredient(ModContent.ItemType<BalanceIngot>(), 15);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}