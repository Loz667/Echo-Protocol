using UnityEngine;

public class Space_Door : MonoBehaviour
{
    private Animator myAnim;

    private void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        myAnim.SetBool("Open", true);
    }

    public void CloseDoor()
    {
        myAnim.SetBool("Open", false);
    }
}
