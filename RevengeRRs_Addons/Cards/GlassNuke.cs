using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace RevengeRRs_Addons.Cards {
    class GlassNuke : CustomCard {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block) {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            gun.damage *= 2;
            block.cdAdd = 0.25f;
            statModifiers.health /= 2;
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats) {
            //Edits values on player when card is selected

        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats) {
            //Run when the card is removed from the player

        }


        protected override string GetTitle() {
            return "Glass Nuke";
        }
        protected override string GetDescription() {
            return "Doubles your damage, but splits the amount of hp you have.";
        }
        protected override GameObject GetCardArt() {
            return null;
        }
        protected override CardInfo.Rarity GetRarity() {
            return CardInfo.Rarity.Uncommon;
        }
        protected override CardInfoStat[] GetStats() {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "DMG",
                    amount = "A TON MORE",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "HP",
                    amount = "A lot less",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Reload Time",
                    amount = "+0.25s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme() {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
        }
        public override string GetModName() {
            return RevengeRRs_Addons.ModInitials;
        }
    }
}
