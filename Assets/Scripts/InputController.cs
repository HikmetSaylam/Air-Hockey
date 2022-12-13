using UnityEngine;

public class InputController : MonoBehaviour
{

    [SerializeField] [Range(0, 1)] private float verticalForce;
    [SerializeField] [Range(0, 1)] private float horizontalForce;

    public float GetVerticalForce(KeyCode up,KeyCode down)
    {
        if (Input.GetKey(up))
            return verticalForce;
        if(Input.GetKey(down))
            return -verticalForce;
        return 0;
    }

    public float GetHorizontalForce(KeyCode right, KeyCode left)
    {
        if (Input.GetKey(right))
            return horizontalForce;
        if(Input.GetKey(left))
            return -horizontalForce;
        return 0;
    }
}
