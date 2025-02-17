﻿using BepInEx.Logging;
using HarmonyLib;
using KSP.Game;

namespace CommunityFixes.Fix;

public abstract class BaseFix : KerbalMonoBehaviour
{
    public virtual void OnInitialized()
    {
    }

    protected Harmony HarmonyInstance { get; }
    internal ManualLogSource Logger { get; }

    protected BaseFix()
    {
        Logger = BepInEx.Logging.Logger.CreateLogSource($"CF/{GetType().Name}");
        HarmonyInstance = new Harmony(GetType().FullName);
    }
}