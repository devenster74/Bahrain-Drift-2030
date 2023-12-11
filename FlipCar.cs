using UnityEngine;

public class FlipCar : MonoBehaviour
{
    // Store the original rotation
    private Quaternion originalRotation;

    // Use this for initialization
    void Start()
    {
        // Save the original rotation of the object
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the 'F' key was pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Reset the object's rotation to the original rotation
            transform.rotation = originalRotation;
        }
    }
}