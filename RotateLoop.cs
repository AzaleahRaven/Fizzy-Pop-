using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 45f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
