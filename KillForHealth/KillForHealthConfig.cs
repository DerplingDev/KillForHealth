using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace KillForHealth 
{
    public class KillForHealthConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        public static KillForHealthConfig Instance;

        [Header("$How much HP should be gained or lost upon killing normal NPCs?")]
        [Label("$Set to negative to lose HP, set to positive to gain HP from\nNPCs such as zombies, slimes, etc.")]
		[Range(-100, 100)]
		[DefaultValue(1)]
		public int hpGained;

        //[Header("$Do Friendly NPCs give HP?")]
        //[Label("$Do NPCs such as critters, town npcs, and more give HP?")]
        //[DefaultValue(false)]
        //public bool friendlyHp;

        [Header("$How much HP should be gained or lost upon killing bosses?")]
        [Label("$Set to negative to lose HP, set to positive to gain HP from\nbosses such as the Eye of Cthulhu, King Slime, etc.")]
		[Range(-100, 100)]
		[DefaultValue(10)]
		public int hpGainedBoss;

        [Header("$How much HP should be gained or lost upon killing friendly NPCs?")]
        [Label("$Set to negative to lose HP, set to positive to gain HP from\nNPCs such as critters, town NPCs, etc.")]
		[Range(-100, 100)]
		[DefaultValue(0)]
		public int hpGainedFriendly;
    }
}