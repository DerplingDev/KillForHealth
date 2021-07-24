using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using System.ComponentModel;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using KillForHealth;

namespace KillForHealth.NPCs
{
    public class KFHPGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void NPCLoot(NPC npc)
	    {
            for (int i = 0; i < 255; i++)
            {
                Player player = Main.player[i];

                if (player.GetModPlayer<KFHPPlayer>().hasAccessory)
                {
                    if (npc.boss)
                    {
                        if (GetInstance<KillForHealthConfig>().giveMaxHP)
                        {
                            player.statLifeMax += GetInstance<KillForHealthConfig>().hpGainedBoss;
                            player.GetModPlayer<KFHPPlayer>().extraHP += GetInstance<KillForHealthConfig>().hpGainedBoss;
                        }
                        else
                        {
                            player.statLife += GetInstance<KillForHealthConfig>().hpGainedBoss;
                        }
                        CombatText.NewText(new Rectangle((int)player.position.X, (int)player.position.Y, 80, 40), Color.Lime, "+ " + GetInstance<KillForHealthConfig>().hpGainedBoss, true);
                    }
                    else if (!npc.friendly)
                    {
                        if (GetInstance<KillForHealthConfig>().giveMaxHP)
                        {
                            player.statLifeMax += GetInstance<KillForHealthConfig>().hpGained;
                            player.GetModPlayer<KFHPPlayer>().extraHP += GetInstance<KillForHealthConfig>().hpGained;
                        }
                        else
                        {
                            player.statLife += GetInstance<KillForHealthConfig>().hpGained;
                        }
                        CombatText.NewText(new Rectangle((int)player.position.X, (int)player.position.Y, 80, 40), Color.Lime, "+ " + GetInstance<KillForHealthConfig>().hpGained, false);
                    }
                }
            }
        }
    }
}