using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform cameraPivot; // the point where the camera is attached, used for looking up/down (pitch)

    [Header("Movement")]
    [SerializeField] private float moveSpeed = 6f; // walking speed
    [SerializeField] private float gravity = -20f; // gravity strength, negative value to pull down

    [Header("Look")]
    [SerializeField] private float mouseSensitivity = 2f; // how fast the player looks around with the mouse
    [SerializeField] private float maxLookAngle = 80f; // limits how far up/down the player can look

    private CharacterController controller; // instead of Rigidbody physics-based movement, we use CharacterController for more precise control
    private float verticalVelocity; // for gravity
    private float pitch; // up/down camera rotation

    private void Awake()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        HandleLook();
        HandleMove();
    }

    private void HandleMove()
    {
        float x = Input.GetAxis("Horizontal"); // A/D
        float z = Input.GetAxis("Vertical");   // W/S

        Vector3 move = (transform.right * x + transform.forward * z) * moveSpeed; // movement direction based on player orientation

        // Gravity
        if (controller.isGrounded && verticalVelocity < 0f)
            verticalVelocity = -2f; // keeps player grounded

        verticalVelocity += gravity * Time.deltaTime;

        move.y = verticalVelocity;

        controller.Move(move * Time.deltaTime);

    }

    private void HandleLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // rotate player body left/right
        transform.Rotate(Vector3.up * mouseX);

        // rotate camera up/down (pitch)
        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, -maxLookAngle, maxLookAngle);

        cameraPivot.localRotation = Quaternion.Euler(pitch, 0f, 0f);
    }
}
