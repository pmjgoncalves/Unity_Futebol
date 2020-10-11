using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public Animator animator;
    public bool slideUp = false;

    public void SlideSettingsPanel()
    {
        if(slideUp)
        {
            animator.Play("Slide Down");
            slideUp = false;
        }
        else
        {
            animator.Play("Slide Up");
            slideUp = true;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level Menu");
    }
}
