using UnityEngine;

public class GhostLocomotion : MonoBehaviour
{
    Transform cameraObject;
    Vector3 moveDirection;
    Rigidbody ghostRB;

    public float movementSpeed = 7f;
    public float rotationSpeed = 15f;

    private void Awake()
    {
        ghostRB = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }

    public void HandleMovement()
    {
        // Move constantly forward relative to the camera
        moveDirection = cameraObject.forward;
        moveDirection = moveDirection + cameraObject.right;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection = moveDirection * movementSpeed;

        Vector3 movementVelocity = moveDirection;
        ghostRB.linearVelocity = movementVelocity;
    }
}
