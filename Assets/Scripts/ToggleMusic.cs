using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMusic : MonoBehaviour
{
    public bool isOn;
    public Image musicButton;

    public Sprite onMusic;
    public Sprite offMusic;

    public AudioSource audioSource;

    void Start()
    {
        isOn = true;    
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("music") ==0)
        {
            musicButton.GetComponent<Image>().sprite = onMusic;
            audioSource.enabled = true;
            isOn = true;
        }
        else if(PlayerPrefs.GetInt("music") == 1)
        {
            musicButton.GetComponent<Image>().sprite = offMusic;
            audioSource.enabled = false;
            isOn = false;
        }
    }
    public void OffSound()
    {
        if(!isOn)
        {
            PlayerPrefs.SetInt("music", 0);
        }
        else if (isOn)
        {
            PlayerPrefs.SetInt("music", 1);
        }
    }
}
