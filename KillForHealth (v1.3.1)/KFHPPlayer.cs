using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using static Terraria.Player;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace KillForHealth
{
    public class KFHPPlayer : ModPlayer
    {
        public bool hasAccessory;
        public int extraHP;

        public override void ResetEffects()
        {
            hasAccessory = false;
        }

        public override TagCompound Save()
        {
            return new TagCompound
            {
                {"extraHP", extraHP}
            };
        }

        public override void Load(TagCompound tag)
        {
            extraHP = tag.GetInt("extraHP");
            player.statLifeMax += extraHP;
        }
    }
}