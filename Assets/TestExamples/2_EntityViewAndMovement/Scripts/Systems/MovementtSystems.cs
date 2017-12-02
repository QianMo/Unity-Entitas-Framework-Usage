//-------------------------------------------------------------------------------------
//	MovementtSystems.cs
//
//	Created by 浅墨
//-------------------------------------------------------------------------------------

using Entitas;

public class MovementSystems : Feature
{
    public MovementSystems(Contexts contexts) : base("Movement Systems")
    {
        Add(new MoveSystem(contexts));
    }
}