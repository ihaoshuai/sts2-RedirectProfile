using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Saves;



namespace RedirctProfile;


[HarmonyPatch(typeof(UserDataPathProvider), nameof(UserDataPathProvider.GetProfileDir))]
public class Patch
{
    static bool Prefix(int profileId, ref string __result) 
    {
        //source
        //Path.Combine(IsRunningModded ? "modded/" : "", $"profile{profileId}");
        __result = Path.Combine($"profile{profileId}");
        return false;
    }

}