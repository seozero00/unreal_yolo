// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "YourYOLOv7Wrapper.h"
#include "YOLODetection.generated.h"

/**
 * 
 */
class HELLO_API AYOLODetection : public AActor
{
	GENERATED_BODY()

public:
	AYOLODetection();

protected:
	virtual void BeginPlay() override;

public:
	virtual void Tick(float DeltaTime) override;

private:
	UFUNCTION()
		void ProcessDetectedObjects(const TArray<FObjectDetectionResult>& DetectedObjects);

	// Other private functions and member variables

};