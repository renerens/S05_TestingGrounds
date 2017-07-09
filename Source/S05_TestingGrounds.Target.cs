// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class S05_TestingGroundsTarget : TargetRules
{
	public S05_TestingGroundsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "S05_TestingGrounds" } );
	}
}
