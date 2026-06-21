using HarmonyLib;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace RedirctProfile;


[ModInitializer(nameof(Init))]
public partial class Main : Godot.Node
{
    public const string ModId = "RedirctProfile";
    public static Logger Logger { get; } = new(ModId, LogType.Generic);


    public static void Init()
    {
        Logger.Info("load mod RedirectProfile");
        Harmony harmony = new(ModId);
        harmony.PatchAll();
    }
}
