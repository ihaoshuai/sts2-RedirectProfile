using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Saves;



namespace RedirctProfile;


[HarmonyPatch(typeof(UserDataPathProvider), nameof(UserDataPathProvider.GetProfileDir), new Type[] { typeof(int), typeof(bool?) })]
public class Patch
{
    static bool Prefix(int profileId, bool? forceModState, ref string __result) 
    {
        //source
        // return GetAccountDir(forceModState).PathJoin($"profile{profileId}");
        __result = UserDataPathProvider.GetAccountDir(false).PathJoin($"profile{profileId}");
        return false;
    }

}