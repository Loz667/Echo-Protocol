using UnityEngine;

[RequireComponent(typeof(Collider2D), typeof(SpriteRenderer))]
public class Door : MonoBehaviour
{
    private Collider2D doorCollider;
    private SpriteRenderer doorRenderer;

    private void Start()
    {
        doorCollider = GetComponent<Collider2D>();
        doorRenderer = GetComponent<SpriteRenderer>();
    }

    public void OpenDoor()
    {
        doorCollider.enabled = false;
        doorRenderer.enabled = false;
    }

    public void CloseDoor()
    {
        doorCollider.enabled = true;
        doorRenderer.enabled = true;
    }
}
