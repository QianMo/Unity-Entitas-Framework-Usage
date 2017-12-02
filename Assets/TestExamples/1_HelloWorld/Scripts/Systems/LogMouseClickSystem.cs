//-------------------------------------------------------------------------------------
//	LogMouseClickSystem.cs
//
//	Created by 浅墨
//-------------------------------------------------------------------------------------

using Entitas;
using UnityEngine;

public class LogMouseClickSystem : IExecuteSystem
{
    readonly GameContext _context;

    public LogMouseClickSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _context.CreateEntity().AddDebugMessage("Left Mouse Button Clicked");
        }

        if (Input.GetMouseButtonDown(1))
        {
            _context.CreateEntity().AddDebugMessage("Right Mouse Button Clicked");
        }
    }
}