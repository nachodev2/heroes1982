// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Heroes1982EditorTarget : TargetRules
{
    public Heroes1982EditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;

        // Mantenemos las reglas de la versión 5.8
        DefaultBuildSettings = BuildSettingsVersion.V7;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;

        // EL FIX DEFINITIVO PARA MOTORES DEL LAUNCHER:
        bOverrideBuildEnvironment = true;

        ExtraModuleNames.Add("Heroes1982");
    }
}