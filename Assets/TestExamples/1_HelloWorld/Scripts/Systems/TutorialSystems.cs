//-------------------------------------------------------------------------------------
//	TutorialSystems.cs
//
//	Created by 浅墨
//-------------------------------------------------------------------------------------

using Entitas;

public class TutorialSystems : Feature
{
    public TutorialSystems(Contexts contexts) : base("Tutorial Systems")
    {
        Add(new HelloWorldSystem(contexts));
        Add(new LogMouseClickSystem(contexts)); // new system
        Add(new DebugMessageSystem(contexts));
        Add(new CleanupDebugMessageSystem(contexts)); // new system (we want this to run last)
    }
}