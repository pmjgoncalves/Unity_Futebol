using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuController : MonoBehaviour
{
    public Animator sliderAnimator;
    public Animator infoAnimator;
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
            sliderAnimator.Play("Slide Down");
            slideUp = false;
        }
        else
        {
            sliderAnimator.Play("Slide Up");
            slideUp = true;
        }
    }
    public void SlideInfoPanel(bool infoUp)
    {
        if (infoUp)
        {
            infoAnimator.Play("Slide Up");
            slideUp = false;
        }
        else
        {
            infoAnimator.Play("Slide Down");
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

    public void OpenFacebookPage()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100008954057994");
    }
}
