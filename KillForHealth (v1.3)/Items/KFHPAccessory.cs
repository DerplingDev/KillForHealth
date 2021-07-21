using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using KillForHealth;

namespace KillForHealth.Items
{
	public class KFHPAccessory : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ring of Endless Blood");
			Tooltip.SetDefault("Equip to gain a specified amount of HP on kill!\nCan be changed in the mod's config!");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.accessory = true;
			item.value = Item.sellPrice(copper: 69);
			item.rare = ItemRarityID.Blue;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<KFHPPlayer>().hasAccessory = true;
		}
	}
}