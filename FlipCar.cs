using UnityEngine;

public class FlipCar : MonoBehaviour
{

    private Quaternion originalRotation;

    void Start()
    {
        originalRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.rotation = originalRotation;
        }
    }
}
