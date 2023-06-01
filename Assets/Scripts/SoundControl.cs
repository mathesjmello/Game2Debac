using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    public Slider slM;
    public Slider slMus;
    public Slider slSfx;
    public AudioMixer aM;
    

    // Start is called before the first frame update
    public void MasterCt(float v)
    {
        aM.SetFloat("master", v);
    } 
    public void MusicCt(float v)
    {
        aM.SetFloat("musica", v);
        
    } 
    public void SFXCt(float v)
    {
        aM.SetFloat("sfx", v);
    } 
}
