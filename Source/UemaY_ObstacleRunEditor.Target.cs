// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UemaY_ObstacleRunEditorTarget : TargetRules
{
	public UemaY_ObstacleRunEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("UemaY_ObstacleRun");
	}
}
