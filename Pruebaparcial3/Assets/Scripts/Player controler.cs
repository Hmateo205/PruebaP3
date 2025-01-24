using UnityEngine;

using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float playerSpeed = 5f;

    private Rigidbody playerRb;
    private Vector3 moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        moveDirection = Vector3.zero;  // Inicializar sin movimiento
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveDirection = Vector3.forward;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            moveDirection = Vector3.back;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            moveDirection = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            moveDirection = Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.Space)) // Para detener el movimiento
        {
            moveDirection = Vector3.zero;
        }
    }

    void FixedUpdate()
    {
        playerRb.linearVelocity = moveDirection * playerSpeed;
    }
}
