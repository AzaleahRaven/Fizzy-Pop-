using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class TryAgain : MonoBehaviour
{
    [Header("Reset Trigger Settings")]
    public string resetTriggerTag = "Player";
    public float resetDelay = 3f;
    public TextMeshProUGUI messageBox;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
            messageBox.text = "Try again!";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(resetTriggerTag))
        {
            StartCoroutine(ResetSceneWithDelay());
        }
    }

    private void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private IEnumerator ResetSceneWithDelay()
    {
        yield return new WaitForSeconds(resetDelay);

        // Reload the scene after the delay
        ResetScene();
    }
}
