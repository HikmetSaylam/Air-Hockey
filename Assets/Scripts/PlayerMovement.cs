using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private InputController inputController;
    [SerializeField] private KeyCode up, down;
    [SerializeField] private float minPosY, maxPosY;
    private Rigidbody2D _rigidbody2D;
    private float _verticalForce;
    private Transform _transform;
    private Vector3 _tmpPosVector;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = transform;
    }
    private void FixedUpdate()
    {
        _verticalForce = inputController.GetVerticalForce(up,down) * speed;
        _rigidbody2D.velocity = Vector2.up * _verticalForce;
        _tmpPosVector = _transform.position;
        _tmpPosVector.y = Mathf.Clamp(_tmpPosVector.y, minPosY, maxPosY);
        _transform.position = _tmpPosVector;
    }
}
