//-------------------------------------------------------------------------------------
//	AddViewSystem.cs
//
//	Created by 浅墨
//-------------------------------------------------------------------------------------

using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

public class AddViewSystem : ReactiveSystem<GameEntity>
{
    readonly Transform _viewContainer = new GameObject("Game Views").transform;
    readonly GameContext _context;

    public AddViewSystem(Contexts contexts) : base(contexts.game)
    {
        _context = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Sprite);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasSprite && !entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity e in entities)
        {
            GameObject go = new GameObject("Game View");
            go.transform.SetParent(_viewContainer, false);
            go.transform.localScale=new Vector3(0.1f, 0.1f, 0.1f);
            //go.GetComponent<mar>SetParent(_viewContainer, false);
            e.AddView(go);
            go.Link(e, _context);
        }
    }
}