using BepInEx;
using HarmonyLib;

namespace Jamesthe1.BarrelRoll {
    [BepInPlugin (pluginGuid, pluginName, pluginVersion)]
    [BepInProcess ("dyingsun.exe")]
    public class BarrelRoll : BaseUnityPlugin {
        // Variables so other classes and this one may use them
        public const string pluginGuid = "jamesthe1.hotds.barrelroll";
        public const string pluginName = "BarrelRoll";
        public const string pluginVersion = "1.0.0.0";

        void Awake () {
            InitHarmony ();
            Logger.LogInfo (pluginName + " has fully loaded and is ready to go!");
        }

        private void InitHarmony () {
            Harmony harmony = new Harmony (pluginGuid);
            Logger.LogInfo ("Patching with harmony...");
            harmony.PatchAll ();
        }
    }
}
