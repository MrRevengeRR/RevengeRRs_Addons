﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;


namespace RevengeRRs_Addons.Cards {
    class Evasive : CustomCard {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block) {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            block.forceToAdd = -10f;
            statModifiers.health = 1.2f;
            block.cdAdd = 0.25f;
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats) {
            //Edits values on player when card is selected

        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats) {
            //Run when the card is removed from the player

        }


        protected override string GetTitle() {
            return "Evasive";
        }
        protected override string GetDescription() {
            return "Launches you the opposite direction from your crosshair.";
        }
        protected override GameObject GetCardArt() {
            return null;
        }
        protected override CardInfo.Rarity GetRarity() {
            return CardInfo.Rarity.Common;
        }
        protected override CardInfoStat[] GetStats() {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "+20%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Block Cooldown",
                    amount = "+0.25s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }

            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme() {
            return CardThemeColor.CardThemeColorType.DefensiveBlue;
        }
        public override string GetModName() {
            return RevengeRRs_Addons.ModInitials;
        }
    }
}

