using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using RevengeRRs_Addons.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using RarityLib.Utils;

namespace RevengeRRs_Addons {
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class RevengeRRs_Addons : BaseUnityPlugin {
        private const string ModId = "me.revengerr.revengerrsaddons";
        private const string ModName = "RevengeRR's Addons";
        public const string Version = "0.0.1"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "RA";

        // Reference to mod's core class
        public static RevengeRRs_Addons instance { get; private set; }

        void Awake() {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();

            //RarityUtils.AddRarity("Troll", 0.1f, new UnityEngine.Color(0.79f, 0.94f, 0.02f), new UnityEngine.Color(0.79f, 0.94f, 0.02f));
        }
        void Start() {
            instance = this;
            CustomCard.BuildCard<Evasive>();
            CustomCard.BuildCard<GlassNuke>();
        }
    }
}

