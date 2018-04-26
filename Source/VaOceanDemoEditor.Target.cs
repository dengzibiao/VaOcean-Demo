// Copyright 2014-2018 Vladimir Alyamkin. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class VaOceanDemoEditorTarget : TargetRules
{
	public VaOceanDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "VaOceanDemo" } );
	}
}
