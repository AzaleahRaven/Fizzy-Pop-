using UnityEngine;

public class EnableObjectOnTrigger : MonoBehaviour
{
    public GameObject objectToEnable;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (objectToEnable != null)
            {
                objectToEnable.SetActive(true);
                Debug.Log("Object has been enabled!");
            }
            else
            {
                Debug.LogWarning("Object to enable is not assigned!");
            }
        }
    }
}
