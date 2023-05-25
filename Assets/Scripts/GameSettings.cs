using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public AudioSource Audio;
    public Text TextButton;

    public GameObject MenuWindow;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OpenMenu()
    {
        MenuWindow.SetActive(true);
    }
    public void CloseMenu()
    {
        MenuWindow.SetActive(false);
    }

    public void AudioMode()
    {

        if (Audio.mute == true)
        {
            Audio.mute = false;
            TextButton.text = "Вкл";
        }
        else
        {
            Audio.mute = true;
            TextButton.text = "Выкл";
        }

    }
}
