using UnityEngine;

public class BallThrower : MonoSingleton<BallThrower>
{
    [SerializeField] private float powerOfThrow;
    private int _directionOfMovement;
    private Transform _transform;

    private void Start()
    {
        var randNum = Random.Range(0, 10);
        _directionOfMovement = (randNum%2==0) ? 1 : -1;
        _transform = transform;
    }

    private void FixedUpdate()
    {
        ThrowBall(_directionOfMovement);
    }

    public void ThrowBall(int direction)
    {
        _transform.position += Vector3.right * powerOfThrow * direction;
    }

    public void SetDirectionOfMovement(int value)
    {
        _directionOfMovement = value;
    }
}
