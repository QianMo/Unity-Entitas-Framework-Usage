//-------------------------------------------------------------------------------------
//	TickUpdateSystem.cs
//
//	Created by 浅墨
//-------------------------------------------------------------------------------------

using Entitas;

/// <summary>
/// 帧计数更新System
/// </summary>

public class TickUpdateSystem : IInitializeSystem, IExecuteSystem
{
    readonly GameContext _context;
    public TickUpdateSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {
        _context.ReplaceTick(0);
    }

    public void Execute()
    {
        if (!_context.isPause)
            _context.ReplaceTick(_context.tick.currentTick + 1);
    }
}