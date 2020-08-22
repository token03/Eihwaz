using Terraria;
using Terraria.ModLoader;

namespace Eihwaz.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class BalanceHelmetYin : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a modded helmet.");
        }
    }
}