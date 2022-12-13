using UnityEngine;

public class BallBouncer : MonoBehaviour
{
    [SerializeField] [Range(-1, 1)] private int direction;
    [SerializeField] private Color targetBallColor;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.collider.tag.Equals("Ball")) return;
        BallThrower.Instance.SetDirectionOfMovement(direction);

    }
}
