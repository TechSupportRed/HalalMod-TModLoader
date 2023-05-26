﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HalalMod.Items.Weapons
{
	public class Detonator : ModItem
	{
		public override void SetStaticDefaults() {

		}

		public override void SetDefaults() {
			Item.useStyle = ItemUseStyleID.Swing;
			Item.shootSpeed = 12f;
			Item.shoot = ModContent.ProjectileType<Projectiles.Detonator>();
			Item.width = 8;
			Item.height = 28;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.UseSound = SoundID.Item1;
			Item.useAnimation = 40;
			Item.useTime = 40;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.value = Item.buyPrice(0, 0, 20, 0);
			Item.rare = ItemRarityID.Blue;
		}
	}
}