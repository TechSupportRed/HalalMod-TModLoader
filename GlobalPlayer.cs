using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace HalalMod
{
	public class GlobalPlayer : ModPlayer
	{
        public bool ExplosionVest = false;
        public float stickyDamage = 0f;

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (RiptideMod.berkserkKey.JustPressed && ExplosionVest)
            {

            }
        }
        public override void ResetEffects()
        {
            stickyDamage = 0f;
        }
    }
}