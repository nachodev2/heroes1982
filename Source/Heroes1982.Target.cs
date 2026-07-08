using UnrealBuildTool;
using System.Collections.Generic;

public class Heroes1982Target : TargetRules
{
    public Heroes1982Target(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;

        // Actualizamos a la versión 5.8
        DefaultBuildSettings = BuildSettingsVersion.V7;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;

        ExtraModuleNames.Add("Heroes1982");
    }
}