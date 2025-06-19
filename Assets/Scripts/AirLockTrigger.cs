using UnityEngine;

public class AirLockTrigger : MonoBehaviour
{
    [SerializeField] private AirLockController airLockController;
    [SerializeField] private Space_Door linkedDoor1;
    [SerializeField] private Space_Door linkedDoor2;

    [SerializeField] private float timeToVent = 5f;
    private float ventTimer = 0f;

    private bool inRange = false;

    private void Update()
    {
        if (inRange)
        {
            airLockController.VentAirLock();
            ventTimer += Time.deltaTime;
            if (ventTimer >= timeToVent)
            {
                linkedDoor1.OpenDoor();
                linkedDoor2.OpenDoor();
                ventTimer = 0f; // Reset timer after venting
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ghost"))
        {
            inRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ghost"))
        {
            inRange = false;
            airLockController.ResetAirlock();
            linkedDoor1.CloseDoor();
            linkedDoor2.CloseDoor();
        }
    }
}
