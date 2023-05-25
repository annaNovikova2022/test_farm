using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public AudioSource Audio;
    public Text TextButton; //Текст кнопки для включения и отключения музыки

    public GameObject MenuWindow;
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    
    //Открыть или закрыть меню настроек
    public void OpenMenu() 
    {
        MenuWindow.SetActive(true);
    }
    public void CloseMenu()
    {
        MenuWindow.SetActive(false);
    }

    //Включение и отключение музыки
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
