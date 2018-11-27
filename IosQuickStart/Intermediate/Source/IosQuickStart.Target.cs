using UnrealBuildTool;

public class IosQuickStartTarget : TargetRules
{
	public IosQuickStartTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("IosQuickStart");
	}
}
