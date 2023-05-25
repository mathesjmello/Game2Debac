using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocador : MonoBehaviour
{
    public AudioSource audio;

    public void Playsound()
    {
        audio.Play();
    }
}
