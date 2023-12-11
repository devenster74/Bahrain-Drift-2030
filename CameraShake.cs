using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeAmount = 0.2f; 
    public float shakeDuration = 1.0f;

    private Vector3 originalPosition;
    private float shakeTimeRemaining;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            shakeTimeRemaining = shakeDuration;
        }

        if (shakeTimeRemaining > 0)
        {
            transform.localPosition = originalPosition + Random.insideUnitSphere * shakeAmount;

            shakeTimeRemaining -= Time.deltaTime;
        }
        else
        {
            shakeTimeRemaining = 0f;
            transform.localPosition = originalPosition;
        }
    }

    void Awake()
    {
        originalPosition = transform.localPosition;
    }
}