using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2;

    [SerializeField]
    private Animator _anim;

    private Vector2 _moveDir;

    public void Move(InputAction.CallbackContext context)
    {
        _moveDir = context.ReadValue<Vector2>();

        if (_anim != null )
        {
            if (_moveDir.magnitude > 0)
            {
                _anim.SetBool("isMoving", true);
                _anim.SetFloat("horizontal", _moveDir.x);
                _anim.SetFloat("vertical", _moveDir.y);
            }
            else
            {
                _anim.SetBool("isMoving", false);
            }
        }
    }

    public void Update()
    {
        transform.position += new Vector3(_moveDir.x, _moveDir.y) * _speed * Time.deltaTime;
    }
}
