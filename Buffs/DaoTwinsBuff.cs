using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Eihwaz.Buffs
{
	public class DaoTwinsBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Dao Twins");
			Description.SetDefault("The Dao Twins will charge and zap your foes");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex){ 

			//Checks if there are more than 0 instances of Minion projectile

			if (player.ownedProjectileCounts[mod.ProjectileType("DaoTwin1")] > 0 && player.ownedProjectileCounts[mod.ProjectileType("DaoTwin2")] > 0)
			{
				player.buffTime[buffIndex] = 18000;
			}
			else // If there are no instances, delete the buff.
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}