// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Heroes1982 : ModuleRules
{
	public Heroes1982(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Heroes1982",
			"Heroes1982/Variant_Platforming",
			"Heroes1982/Variant_Platforming/Animation",
			"Heroes1982/Variant_Combat",
			"Heroes1982/Variant_Combat/AI",
			"Heroes1982/Variant_Combat/Animation",
			"Heroes1982/Variant_Combat/Gameplay",
			"Heroes1982/Variant_Combat/Interfaces",
			"Heroes1982/Variant_Combat/UI",
			"Heroes1982/Variant_SideScrolling",
			"Heroes1982/Variant_SideScrolling/AI",
			"Heroes1982/Variant_SideScrolling/Gameplay",
			"Heroes1982/Variant_SideScrolling/Interfaces",
			"Heroes1982/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
