﻿using HarmonyLib;

namespace Utsuho_character_mod
{
    public static class PInfo
    {
        // each loaded plugin needs to have a unique GUID. usually author+generalCategory+Name is good enough
        public const string GUID = "zosit.lbol.test.utsuho";
        public const string Name = "Character Mod";
        public const string version = "1.0.0";
        public static readonly Harmony harmony = new Harmony(GUID);

    }
}
