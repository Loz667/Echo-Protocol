using UnityEngine;

public class InputManager : MonoBehaviour
{
    InputSystem_Actions playerControls;

    Vector2 movementInput;

    public float verticalInput;
    public float horizontalInput;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new InputSystem_Actions();

            playerControls.Player.Move.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.Player.Move.canceled += i => movementInput = Vector2.zero;
        }

        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
