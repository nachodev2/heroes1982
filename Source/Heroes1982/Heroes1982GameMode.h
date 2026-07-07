// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "Heroes1982GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AHeroes1982GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AHeroes1982GameMode();
};



