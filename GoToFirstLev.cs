using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToFirstLev : MonoBehaviour
{
    // Method to change to the "FirstLevel" scene
    public void ChangeToFirstLevel()
    {
        SceneManager.LoadScene("FirstLevel");
    }
}
