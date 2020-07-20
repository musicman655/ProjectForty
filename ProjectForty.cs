using Terraria.ModLoader;
using Terraria;
using static Terraria.ModLoader.ModContent;
namespace ProjectForty
{
	public class ProjectForty : Mod
	{
		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if(Main.myPlayer != -1 && !Main.gameMenu)
			{
				Player player = Main.LocalPlayer;
				if(player.active && Main.dayTime && player.ZoneOverworldHeight && GetInstance<ProjectFortyConfig>().Day)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Day");	
					priority = MusicPriority.BiomeLow;
				}
				if(player.active && !Main.dayTime && player.ZoneOverworldHeight && GetInstance<ProjectFortyConfig>().Night)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Night");
					priority = MusicPriority.BiomeLow;
				}
				if(player.active && player.ZoneRockLayerHeight && GetInstance<ProjectFortyConfig>().Cavern)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Cavern");
					priority = MusicPriority.BiomeMedium;
				}
				if(player.active && player.ZoneJungle && !player.ZoneRockLayerHeight && GetInstance<ProjectFortyConfig>().Jungle)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Jungle");
					priority = MusicPriority.BiomeMedium;
				}
				if(player.active && player.ZoneCrimson && !player.ZoneRockLayerHeight && GetInstance<ProjectFortyConfig>().Crimson)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/Crimson");
					priority = MusicPriority.BiomeHigh;
				}
				if(player.active && player.ZoneCorrupt && !player.ZoneRockLayerHeight)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/Corruption");
					priority = MusicPriority.BiomeHigh;
				}
				if(player.active && player.ZoneBeach && !player.ZoneRockLayerHeight && GetInstance<ProjectFortyConfig>().Ocean)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/Ocean");
					priority = MusicPriority.BiomeLow;
				}
				if(player.active && player.ZoneSnow && !player.ZoneRockLayerHeight && GetInstance<ProjectFortyConfig>().Snow)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/Snow");
					priority = MusicPriority.BiomeMedium;
				}
				if(player.active && player.ZoneSkyHeight && GetInstance<ProjectFortyConfig>().Space)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/Space");
					priority = MusicPriority.Environment;
				}
				if(player.active && player.ZoneUnderworldHeight && GetInstance<ProjectFortyConfig>().Underworld)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/Underworld");
					priority = MusicPriority.Environment;
				}
				if(player.active && player.ZoneDesert && !player.ZoneUndergroundDesert && !player.ZoneRockLayerHeight && GetInstance<ProjectFortyConfig>().Desert)
				{
					music = GetSoundSlot(SoundType.Music, "Sounds/Music/Desert");
					priority = MusicPriority.BiomeLow;
				}
			}
		}
	}
}