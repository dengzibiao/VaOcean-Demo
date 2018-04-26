// Copyright 2014-2018 Vladimir Alyamkin. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class VaOceanDemoTarget : TargetRules
{
	public VaOceanDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "VaOceanDemo" } );
	}
}
