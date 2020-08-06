using Terraria.ID;
using Terraria.ModLoader;

namespace Eihwaz.Items
{
    public class YangCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'You feel a warming sense of comfort'");
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