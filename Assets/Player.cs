using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public InputSystem_Actions inputAction;

    private InputAction move;
    private InputAction attack;


    private Rigidbody rb;
    private Vector3 direction;

    public float speed;

    private void Awake()
    {
        inputAction = new InputSystem_Actions();
    }


    private void OnEnable()
    {
        move = inputAction.Player.Move;
        attack = inputAction.Player.Attack;

        attack.performed += AttackButton;
        move.Enable();
        attack.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        attack.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        direction = move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(direction.x * speed, 0, direction.y * speed);
    }

    public void AttackButton(InputAction.CallbackContext context)
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAA");
    }
}