using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Eihwaz.Projectiles;

namespace Eihwaz.Items.Weapons
{
    public class StaffOfDao : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons a pair of Dao Twins to fight for you");
        }

        public override void SetDefaults()
        {
            item.damage = 60;
            item.mana = 10;
            item.summon = true;
            item.noMelee = true;

            item.width = 54;
            item.height = 54;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.value = 10000;
            item.rare = ItemRarityID.Yellow;
            item.UseSound = SoundID.Item44;
            item.buffType = mod.BuffType("DaoTwinsBuff");
            item.shoot = mod.ProjectileType("DaoTwin1");

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            player.AddBuff(item.buffType, 2);
            position = Main.MouseWorld;
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<DaoTwin2>(), damage, knockBack, player.whoAmI);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LightShard);
            recipe.AddIngredient(ItemID.DarkShard);
            recipe.AddRecipeGroup("Eihwaz:GoldPlatinumBar", 3);
            recipe.AddIngredient(ModContent.ItemType<BalanceIngot>(), 7);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}