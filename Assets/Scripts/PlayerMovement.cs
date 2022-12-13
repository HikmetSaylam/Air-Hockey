using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private InputController inputController;
    [SerializeField] private KeyCode up, down, right, left;
    [SerializeField] private float minPosY, maxPosY, minPosX, maxPosX;
    private Rigidbody2D _rigidbody2D;
    private float _verticalForce;
    private Transform _transform;
    private Vector3 _tmpPosVector;
    private Vector3 _movementVector3;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = transform;
        _movementVector3=Vector3.zero;
    }
    private void FixedUpdate()
    {
        _movementVector3.y = inputController.GetVerticalForce(up,down);
        _movementVector3.x = inputController.GetHorizontalForce(right, left);
        _rigidbody2D.velocity = _movementVector3 * speed;
        _tmpPosVector = _transform.position;
        _tmpPosVector.y = Mathf.Clamp(_tmpPosVector.y, minPosY, maxPosY);
        _tmpPosVector.x = Mathf.Clamp(_tmpPosVector.x, minPosX, maxPosX);
        _transform.position = _tmpPosVector;
    }
}
