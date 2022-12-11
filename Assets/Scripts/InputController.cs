using UnityEngine;

public class InputController : MonoBehaviour
{

    [SerializeField] [Range(0, 1)] private float verticalForce;

    public float GetVerticalForce(KeyCode up,KeyCode down)
    {
        if (Input.GetKey(up))
            return verticalForce;
        if(Input.GetKey(down))
            return -verticalForce;
        return 0;
    }
}
