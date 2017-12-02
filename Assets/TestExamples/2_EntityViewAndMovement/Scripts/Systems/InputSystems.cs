//-------------------------------------------------------------------------------------
//	InputSystems.cs
//
//	Created by 浅墨
//-------------------------------------------------------------------------------------

using Entitas;

public class InputSystems : Feature
{
    public InputSystems(Contexts contexts) : base("Input Systems")
    {
        Add(new EmitInputSystem(contexts));
        Add(new CreateMoverSystem(contexts));
        Add(new CommandMoveSystem(contexts));
    }
}