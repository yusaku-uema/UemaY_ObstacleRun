// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UemaY_ObstacleRun : ModuleRules
{
	public UemaY_ObstacleRun(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
