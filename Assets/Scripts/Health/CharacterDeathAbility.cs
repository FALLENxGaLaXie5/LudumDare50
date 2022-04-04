using MoreMountains.CorgiEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeathAbility : CharacterAbility
{
    [SerializeField] private GameEvent deathEvent;
    
    protected override void OnDeath()
    {
        base.OnDeath();
        deathEvent.Raise();
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
