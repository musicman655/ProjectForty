using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using System.ComponentModel;
namespace ProjectForty
{
    public class ProjectFortyConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [DefaultValue(true)]
        [Label("Enable Day Theme")]
        [Tooltip("Set this to false to disable the Day theme and play the vanilla counterpart")]
        public bool Day;

        [DefaultValue(true)]
        [Label("Enable Night Theme")]
        [Tooltip("Set this to false to disable the Night theme and play the vanilla counterpart")]
        public bool Night;

        [DefaultValue(true)]
        [Label("Enable Ocean Theme")]
        [Tooltip("Set this to false to disable the Ocean theme and play the vanilla counterpart")]
        public bool Ocean;

        [DefaultValue(true)]
        [Label("Enable Cavern Theme")]
        [Tooltip("Set this to false to disable the Cavern theme and play the vanilla counterpart")]
        public bool Cavern;

        [DefaultValue(true)]
        [Label("Enable Jungle Theme")]
        [Tooltip("Set this to false to disable the Jungle theme and play the vanilla counterpart")]
        public bool Jungle;

        [DefaultValue(true)]
        [Label("Enable Space Theme")]
        [Tooltip("Set this to false to disable the Space theme and play the vanilla counterpart")]
        public bool Space;

        [DefaultValue(true)]
        [Label("Enable Snow Theme")]
        [Tooltip("Set this to false to disable the Snow theme and play the vanilla counterpart")]
        public bool Snow;

        [DefaultValue(true)]
        [Label("Enable Desert Theme")]
        [Tooltip("Set this to false to disable the Desert theme and play the vanilla counterpart")]
        public bool Desert;

        [DefaultValue(true)]
        [Label("Enable Jungle Theme")]
        [Tooltip("Set this to false to disable the Jungle theme and play the vanilla counterpart")]
        public bool Crimson;

        [DefaultValue(true)]
        [Label("Enable Corruption Theme")]
        [Tooltip("Set this to false to disable the Corruption theme and play the vanilla counterpart")]
        public bool Corruption;

        [DefaultValue(true)]
        [Label("Enable Underworld Theme")]
        [Tooltip("Set this to false to disable the Underworld theme and play the vanilla counterpart")]
        public bool Underworld;

    }
}