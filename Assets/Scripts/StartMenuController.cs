using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuController : MonoBehaviour
{
    public Animator animator;
    public Button soundButton;
    public Sprite soundOn, soundOff;
    private AudioSource audioSource;
    private bool slideUp = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
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
    public void LoadScene()
    {
        SceneManager.LoadScene("Level Menu");
    }
    public void SetAudio()
    {
        if (audioSource.mute)
        {
            audioSource.mute = !audioSource.mute;
            soundButton.image.sprite = soundOn;
        }
        else
        {
            audioSource.mute = !audioSource.mute;
            soundButton.image.sprite = soundOff;
        }
    }
}
