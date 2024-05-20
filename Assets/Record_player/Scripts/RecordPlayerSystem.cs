using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayerSystem : MonoBehaviour
{
    public RecordPlayer player;
    public Disc disc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play()
    {
        UnityEngine.Debug.Log("Play");
        player.disc = disc;
        Debug.Log(player.disc);
        Debug.Log(disc);
        player.recordPlayerActive = true;
    }

    public void Stop()
    {
        Debug.Log("Stop");
        player.recordPlayerActive = false;
        player.mode = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
