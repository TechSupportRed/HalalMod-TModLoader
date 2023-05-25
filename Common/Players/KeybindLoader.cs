using Terraria;
using Terraria.ID;
using Terraria.GameInput;
using Terraria.ModLoader;
using HalalMod.Common.Systems;

namespace HalalMod.Common.Players
{
	// See Common/Systems/KeybindSystem for keybind registration.
	public class KeybindLoader : ModPlayer
	{
		public override void ProcessTriggers(TriggersSet triggersSet) {
			if (KeybindSystem.ExplosionVestKeybind.JustPressed) {
				Main.NewText($"HalalMod's ModKeybind was just pressed. The buff was given to the player.");
			}
		}
	}
}