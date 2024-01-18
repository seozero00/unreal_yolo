// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class hello : ModuleRules
{
	public hello(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

        PublicIncludePaths.AddRange(
                   new string[] {
                "C:\Users\Joongsul Nam\Documents\Unreal Projects\hello\Source\ThirdParty\yolov7-cxx-main\src\yolov7_cxx",
                       // ... 다른 include 경로들 ...
                   }
               );

        // YourProject/Source/ThirdParty/yolov7-cxx-main/demo/main.cpp 파일 추가
        PublicSourcePaths.Add("C:\Users\Joongsul Nam\Documents\Unreal Projects\hello\Source\ThirdParty\yolov7-cxx-main\demo\main.cpp");
        // YourProject/Source/ThirdParty/yolov7-cxx-main/src/yolov7_cxx/yolov7_cxx.cpp 파일 추가
        PublicSourcePaths.Add("C:\Users\Joongsul Nam\Documents\Unreal Projects\hello\Source\ThirdParty\yolov7-cxx-main\src\yolov7_cxx\yolov7_cxx.cpp");
        PublicSourcePaths.Add("C:\Users\Joongsul Nam\Documents\Unreal Projects\hello\Source\ThirdParty\yolov7-cxx-main\src\yolov7_cxx\yolov7_cxx.h")
        // 추가적인 설정들...
    }
}

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
