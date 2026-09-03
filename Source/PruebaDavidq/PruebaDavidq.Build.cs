// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PruebaDavidq : ModuleRules
{
	public PruebaDavidq(ReadOnlyTargetRules Target) : base(Target)
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
			"PruebaDavidq",
			"PruebaDavidq/Variant_Platforming",
			"PruebaDavidq/Variant_Platforming/Animation",
			"PruebaDavidq/Variant_Combat",
			"PruebaDavidq/Variant_Combat/AI",
			"PruebaDavidq/Variant_Combat/Animation",
			"PruebaDavidq/Variant_Combat/Gameplay",
			"PruebaDavidq/Variant_Combat/Interfaces",
			"PruebaDavidq/Variant_Combat/UI",
			"PruebaDavidq/Variant_SideScrolling",
			"PruebaDavidq/Variant_SideScrolling/AI",
			"PruebaDavidq/Variant_SideScrolling/Gameplay",
			"PruebaDavidq/Variant_SideScrolling/Interfaces",
			"PruebaDavidq/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
