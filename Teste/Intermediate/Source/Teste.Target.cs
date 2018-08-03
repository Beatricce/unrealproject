using UnrealBuildTool;

public class TesteTarget : TargetRules
{
	public TesteTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Teste");
	}
}
