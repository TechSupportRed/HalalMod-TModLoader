using Terraria.ModLoader;

namespace HalalMod
{
	public class HalalMod : Mod
    {
          //This creates a key that terraria and the controls settings natively know how to handle
          public static ModHotKey berserkKey;

        //Loads confdig related stuff such as hotkeys for controls settings in UI
        public override void Load()
        {
            berserkKey = RegisterHotKey("Berserk", "r");
        }
    }
}
