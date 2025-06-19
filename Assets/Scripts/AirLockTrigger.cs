using System.Collections.Generic;
using UnityEngine;

public class AirLockTrigger : MonoBehaviour
{
    [SerializeField] private AirLockController airLockController;
    [SerializeField] private Space_Door linkedDoor1;
    [SerializeField] private Space_Door linkedDoor2;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ghost"))
        {
            airLockController.VentAirLock();
            linkedDoor1.OpenDoor();
            linkedDoor2.OpenDoor();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ghost"))
        {
            airLockController.ResetAirlock();
            linkedDoor1.CloseDoor();
            linkedDoor2.CloseDoor();
        }
    }
}
