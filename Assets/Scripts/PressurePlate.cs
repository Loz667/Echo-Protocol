using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] Door linkedDoor;

    private int triggerCount = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ghost"))
        {
            triggerCount++;
            linkedDoor.OpenDoor();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ghost"))
        {
            triggerCount--;
            if (triggerCount <= 0) linkedDoor.CloseDoor();
        }
    }
}
