// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "YOLOv7Wrapper.generated.h"

/**
 * 
 */
USTRUCT(BlueprintType)
struct FObjectDetectionResult
{
	GENERATED_BODY()

		// Define variables to represent the detected object's information
};

UCLASS()
class HELLO_API YOLOv7Wrapper : public UObject
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable, Category = "YOLOv7")
		static TArray<FObjectDetectionResult> RunYOLOv7(/* Add necessary parameters like camera input here */);

	// Add any additional functions or variables as needed
};