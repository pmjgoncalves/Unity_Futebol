using UnityEngine;
using UnityEngine.SceneManagement;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using UnityEngine.UI;
#pragma warning restore IDE0005 // Using directive is unnecessary.

public class LevelMenuController : MonoBehaviour
{
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
