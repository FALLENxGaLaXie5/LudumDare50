using UnityEngine;
using MoreMountains.CorgiEngine;

namespace DefaultNamespace
{
    public class PathedIncreasingVelocityProjectile : PathedProjectile
    {
        [SerializeField] private float speedIncreaseRate = 1f;

        protected override void Update()
        {
            transform.position=Vector3.MoveTowards(transform.position,_destination.position,Time.deltaTime * _speed);
            float distanceSquared = (_destination.transform.position - transform.position).sqrMagnitude;
            _speed += (Time.deltaTime * speedIncreaseRate);
            if(distanceSquared > .01f * .01f)
            {
                return;
            }

            DestroyFeedbacks?.PlayFeedbacks();			
			
            Destroy(gameObject);
        }
    }
}