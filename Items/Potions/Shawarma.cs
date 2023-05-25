using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace HalalMod.Items.Potions
{
	public class Shawarma : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shelby's Shawarma"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Restores 150 life, I will give you somesing beddar");
		}

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.value = 50;
			Item.rare = 0;
			Item.UseSound = SoundID.Item3;
			Item.potion = true;
			Item.consumable = true;
			Item.healLife = 150;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.Register();
		}

	}
}