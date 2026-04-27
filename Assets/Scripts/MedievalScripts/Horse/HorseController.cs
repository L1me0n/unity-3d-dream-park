using UnityEngine;

public class HorseController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float maxForwardSpeed = 8f;
    [SerializeField] private float maxBackwardSpeed = 3f;
    [SerializeField] private float acceleration = 10f;
    [SerializeField] private float deceleration = 12f;
    [SerializeField] private float turnSpeed = 120f;

    [Header("Grounding")]
    [SerializeField] private float gravity = -20f;

    private CharacterController controller;
    private float currentSpeed;
    private float verticalVelocity;
    private bool isMounted = false;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (!isMounted)
        {
            ApplyIdleGravity();
            return;
        }

        HandleMovement();
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float targetSpeed = 0f;

        if (vertical > 0f)
        {
            targetSpeed = vertical * maxForwardSpeed;
        }
        else if (vertical < 0f)
        {
            targetSpeed = vertical * maxBackwardSpeed;
        }

        float speedChangeRate = Mathf.Abs(targetSpeed) > Mathf.Abs(currentSpeed) ? acceleration : deceleration;
        currentSpeed = Mathf.MoveTowards(currentSpeed, targetSpeed, speedChangeRate * Time.deltaTime);

        float turnAmount = horizontal;

        if (Mathf.Abs(currentSpeed) > 0.1f)
        {
            transform.Rotate(Vector3.up, turnAmount * turnSpeed * Time.deltaTime);
        }

        if (controller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = transform.forward * currentSpeed;
        move.y = verticalVelocity;

        controller.Move(move * Time.deltaTime);
    }

    private void ApplyIdleGravity()
    {
        if (controller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = Vector3.up * verticalVelocity;
        controller.Move(move * Time.deltaTime);
    }

    public void SetMounted(bool mounted)
    {
        isMounted = mounted;

        if (!isMounted)
        {
            currentSpeed = 0f;
        }
    }

    public bool IsMounted()
    {
        return isMounted;
    }

    public float GetNormalizedSpeed()
    {
        return Mathf.Abs(currentSpeed) / maxForwardSpeed;
    }
}