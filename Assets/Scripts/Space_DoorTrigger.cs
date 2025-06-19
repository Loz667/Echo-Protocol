using UnityEngine;

public class Space_DoorTrigger : MonoBehaviour
{
    [SerializeField] Space_Door linkedDoor;

    private int triggerCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ghost"))
        {
            triggerCount++;
            linkedDoor.OpenDoor();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ghost"))
        {
            triggerCount--;
            if (triggerCount <= 0) linkedDoor.CloseDoor();
        }
    }
}
