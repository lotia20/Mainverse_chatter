using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CustomCharacterController : MonoBehaviour
{
    public float stepOffset;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, stepOffset))
        {
            float distanceToGround = hit.distance;
            if (distanceToGround > 0f && distanceToGround <= stepOffset)
            {
                rb.MovePosition(rb.position + Vector3.up * (stepOffset - distanceToGround));
            }
        }
    }
}