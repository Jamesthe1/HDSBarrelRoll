using System;
using HarmonyLib;
using UnityEngine;

namespace Jamesthe1.BarrelRoll {
    [HarmonyPatch (typeof (Unit), "FixedUpdate")]
    public class Unit_FixedUpdate {
        // Postfix comes after the function, a la post
        public static void Postfix (Unit __instance) {
            if (!__instance.isPlayer && !Game.isSimulationPaused)
                __instance.rotation *= Quaternion.Euler (0, 0, 5);
        }
    }
}
