using UnityEngine;

using UnityEngine.UI;
using UnityEngine.Audio;

public class Volume_script: MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;

       public AudioMixer MainMixer;

   

       private void Start()
       {
           
       }

        private void Update()
       {




           SetMusicVolume();
            SetSFXVolume();


        


       }


    public void SetSFXVolume()
    { 
          float volume = sfxSlider.value;
        MainMixer.SetFloat("sfx volume", Mathf.Log10(volume)*20);
    }

    
    public void SetMusicVolume()
    { 
         float volume = musicSlider.value;
        MainMixer.SetFloat("music volume", Mathf.Log10(volume)*20);

    }
}