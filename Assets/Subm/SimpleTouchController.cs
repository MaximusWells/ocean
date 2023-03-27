using UnityEngine;

public class SimpleTouchController : MonoBehaviour
{
    public float speed = 10.0f;
    public Joystick joystick;

    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        Vector3 inputVector = new Vector3(horizontal, 0, vertical);

        if (inputVector != Vector3.zero)
        {
            // Rotate the character to face the direction of movement
            transform.LookAt(transform.position + inputVector);

            // Move the character in the direction of the joystick
            Vector3 movementVector = inputVector * speed;
            characterController.Move(movementVector * Time.deltaTime);
        }
    }
}
