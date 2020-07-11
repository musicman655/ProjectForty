using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
namespace ProjectForty
{
	public class ProjectForty : Mod
	{
		public override void Close()
        {
            // Fix a tModLoader bug.
            var slots = new int[] {
                GetSoundSlot(SoundType.Music, "Sounds/Music/Day"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Night"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Cavern"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Desert"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Snow"),
            };
            foreach (var slot in slots) // Other mods crashing during loading can leave Main.music in a weird state.
            {
                if (Main.music.IndexInRange(slot) && Main.music[slot]?.IsPlaying == true)
                {
                    Main.music[slot].Stop(Microsoft.Xna.Framework.Audio.AudioStopOptions.Immediate);
                }
            }

            base.Close();
        }
		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if(Main.myPlayer != -1 && !Main.gameMenu)
			{
				Player player = Main.LocalPlayer;
				if(player.active && Main.dayTime && !player.ZoneRockLayerHeight)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Day");	
					priority = MusicPriority.BiomeLow;
				}
				if(player.active && !Main.dayTime && !player.ZoneRockLayerHeight)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Night");
					priority = MusicPriority.BiomeLow;
				}
				if(player.active && player.ZoneJungle && !player.ZoneRockLayerHeight)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Jungle");
					priority = MusicPriority.BiomeMedium;
				}
				if(player.active && player.ZoneRockLayerHeight)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Cavern");
					priority = MusicPriority.BiomeLow;
				}				
				if(player.active && player.ZoneDesert && !player.ZoneRockLayerHeight)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Desert");
					priority = MusicPriority.BiomeLow;
				}
				if(player.active && player.ZoneSnow && !player.ZoneRockLayerHeight)
				{
					music = GetSoundSlot(SoundType.Music,"Sounds/Music/Snow");
					priority = MusicPriority.BiomeMedium;
				}						
			}	
		}
	}
}
