using Terraria.ID;
using Terraria.ModLoader;

namespace Eihwaz.Items
{
    public class YinEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'You feel a chilling sense of dread'");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.value = 2300;
            item.rare = ItemRarityID.Yellow;
        }
    }
}