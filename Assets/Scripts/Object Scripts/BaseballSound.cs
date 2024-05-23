using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseballSound : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioClip ballBounce;

    void OnCollisionEnter(Collision collision)
    {
        // Adjusting volume scale
        audioPlayer.PlayOneShot(ballBounce, 0.7f);
    }
}
