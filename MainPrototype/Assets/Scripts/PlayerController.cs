using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2;

    private Vector2 moveDir;

    public void Move(InputAction.CallbackContext context)
    {
        moveDir = context.ReadValue<Vector2>();
    }

    public void Update()
    {
        transform.position += new Vector3(moveDir.x, moveDir.y) * _speed * Time.deltaTime;
    }
}
