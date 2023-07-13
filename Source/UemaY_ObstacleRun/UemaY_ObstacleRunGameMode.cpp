// Copyright Epic Games, Inc. All Rights Reserved.

#include "UemaY_ObstacleRunGameMode.h"
#include "UemaY_ObstacleRunCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUemaY_ObstacleRunGameMode::AUemaY_ObstacleRunGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
