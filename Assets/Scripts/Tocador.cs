using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocador : MonoBehaviour
{
    public AudioSource audio;
    public bool change;
    private int i;
    public AudioClip[] clips;

        public void Playsound()
    {
        if (change)
        {
            audio.clip = clips[i % 2];
            i++;
        }
        audio.Play();
    }

        public void Para()
        {
            gameObject.SetActive(false);
        }
}
