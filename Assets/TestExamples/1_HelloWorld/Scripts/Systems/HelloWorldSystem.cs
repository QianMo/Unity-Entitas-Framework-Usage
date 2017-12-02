//-------------------------------------------------------------------------------------
//	HelloWorldSystem.cs
//
//	Created by 浅墨
//-------------------------------------------------------------------------------------

using Entitas;

public class HelloWorldSystem : IInitializeSystem
{
    // always handy to keep a reference to the context 
    // we're going to be interacting with it
    readonly GameContext _context;

    public HelloWorldSystem(Contexts contexts)
    {
        // get the context from the constructor
        _context = contexts.game;
    }

    public void Initialize()
    {
        // create an entity and give it a DebugMessageComponent with
        // the text "Hello World!" as its data
        _context.CreateEntity().AddDebugMessage("Hello World!");
    }
}