using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Camera cam;
    private Rigidbody rb;
    [HideInInspector] public Vector3 moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main.GetComponent<Camera>();
    }

    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        moveDirection = new Vector3(Horizontal, 0f, Vertical).normalized;

        //if(moveDirection.magnitude >= 0.1f)
        //{
        //    float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
        //    float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);
        //    transform.rotation = Quaternion.Euler(0f, angle, 0f);

        //}
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Impulse);
    }
}
