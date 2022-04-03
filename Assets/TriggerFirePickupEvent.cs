using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFirePickupEvent : MonoBehaviour
{
    [SerializeField] private GameEvent firePickupEvent;

    public void TriggerFirePickup()
    {
        firePickupEvent?.Raise();
    }
}
