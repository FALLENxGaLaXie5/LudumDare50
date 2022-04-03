using System.Collections;
using MoreMountains.CorgiEngine;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeteriorateHealth : MonoBehaviour
{
    [SerializeField][Range(5f, 15f)] private float minTimeBetweenDeterioration = 10f;
    [SerializeField][Range(15f, 30f)] private float maxTimeBetweenDeterioration = 25f;
    [SerializeField] private int deteriorationStepAmount = 5;
    private Health health;
    
    private void Awake()
    {
        health = GetComponent<Health>();
    }

    private void Start()
    {
        StartCoroutine(Deteriorate());
    }

    private IEnumerator Deteriorate()
    {
        while (health.CurrentHealth > 0)
        {
            yield return new WaitForSeconds(Random.Range(minTimeBetweenDeterioration, maxTimeBetweenDeterioration));
            health.Damage(deteriorationStepAmount, gameObject, 0.3f, 0.1f, Vector3.up);
        }
        yield return null;
    }
}