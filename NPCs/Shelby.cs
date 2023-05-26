using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using HalalMod.Items;
using HalalMod.Items.Potions;

namespace HalalMod.NPCs
{
    [AutoloadHead]
    public class Shelby : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shelby's Shawarma");
        }
        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 20;
            NPC.height = 20;
            NPC.aiStyle = 7;
            NPC.defense = 35;
            NPC.lifeMax = 300;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            Main.npcFrameCount[NPC.type] = 25;
            NPCID.Sets.ExtraFramesCount[NPC.type] = 0;
            NPCID.Sets.AttackFrameCount[NPC.type] = 1;
            NPCID.Sets.DangerDetectRange[NPC.type] = 500;
            NPCID.Sets.AttackType[NPC.type] = 1;
            NPCID.Sets.AttackTime[NPC.type] = 30;
            NPCID.Sets.AttackAverageChance[NPC.type] = 10;
            NPCID.Sets.HatOffsetY[NPC.type] = 4;
            AnimationType = 22;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (Main.hardMode)
            {
                return true;
            }
            return false;
        }


        public override List<string> SetNPCNameList()
        {
            return new List<string>()
            {
                "Galagoon",
                "Shelby",
                "Somesing beddar"
            };
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Shop";
            button2 = "Sbeak to me";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Shawarma>());
            shop.item[nextSlot].value = 50;
        }

        public override string GetChat()
        {
            NPC.FindFirstNPC(ModContent.NPCType<Shelby>());
            switch (Main.rand.Next(3))
            {
                case 0:
                    return "Ehhh... I will give you somesing beddar";
                case 1:
                    return "Za best in za west!";
                case 2:
                    return "My friend! Don't forget za bebsi";
                default:
                    return "My friend! If it's not right, it's not right!";
            }
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 200;
            knockback = 2f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 5;
            randExtraCooldown = 10;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.WoodenArrowFriendly;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 7f;
        }

        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.GoldBow, 1, false, 0, false, false);
        }
    }
}
