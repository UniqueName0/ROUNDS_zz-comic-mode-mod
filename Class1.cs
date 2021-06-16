using BepInEx;
using HarmonyLib;
using UnityEngine;
using System;
using System.Reflection;
using HarmonyLib.Tools;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace W_jump
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInProcess("Rounds.exe")]
    [BepInPlugin("uniquename.rounds.zz-comic-mode", "zz-comic-mode", "0.0.0.0")]
    public class W_Jump : BaseUnityPlugin
    {

        public void Awake()
        {
            var harmony = new Harmony("uniquename.rounds.zz-comic-mode");
            harmony.PatchAll();
        }

        public const string modID = "uniquename.rounds.zz-comic-mode";
        public const string modName = "zz-comic-mode";
    }

    [HarmonyPatch(typeof(Block), "TryBlock")]
    public class zz_comic_Patch
    {
        public static bool Prefix(Block __instance)
        {
            return false;
        }
    }
}
