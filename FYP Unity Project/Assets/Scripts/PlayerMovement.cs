using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float turnSpeed;
    public float jumpForce;

    private Rigidbody rigidbody;
    private CapsuleCollider collider;
    private bool jumpIsPressed;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        collider = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        _checkReleasedKeys();
    }

    void FixedUpdate()
    {
        _updateMovement();
    }

    void _updateMovement()
    {
        if (Input.GetAxis("Vertical") > 0)
            rigidbody.AddForce(transform.forward * movementSpeed * Time.deltaTime);
        else if (Input.GetAxis("Vertical") < 0)
            rigidbody.AddForce(-transform.forward * movementSpeed * Time.deltaTime);

        if (Input.GetAxis("Horizontal") > 0)
        {
            Quaternion rotation = Quaternion.Euler(0, turnSpeed * Time.deltaTime, 0);
            rigidbody.MoveRotation(transform.rotation * rotation);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            Quaternion rotation = Quaternion.Euler(0, -turnSpeed * Time.deltaTime, 0);
            rigidbody.MoveRotation(transform.rotation * rotation);
        }

        if (Input.GetAxis("Jump") == 1 && !jumpIsPressed && _isGrounded())
        {
            jumpIsPressed = true;
            _jump();
        }
    }

    void _checkReleasedKeys()
    {
        if (jumpIsPressed && Input.GetAxis("Jump") == 0)
            jumpIsPressed = false;
    }

    bool _isGrounded()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 0.5f * collider.height + 0.1f))
            return true;
        else return false;
    }

    void _jump()
    {
        Debug.Log("jumps");
        rigidbody.AddForce(transform.up * jumpForce);
    }

}
