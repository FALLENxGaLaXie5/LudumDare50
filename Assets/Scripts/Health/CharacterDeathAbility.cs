using MoreMountains.CorgiEngine;
using UnityEngine;

public class CharacterDeathAbility : CharacterAbility
{
    [SerializeField] private GameEvent deathEvent;
    
    protected override void OnDeath()
    {
        base.OnDeath();
        deathEvent.Raise();
    }
}
