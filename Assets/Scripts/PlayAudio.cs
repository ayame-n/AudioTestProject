using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource audio;
    [SerializeField]
    private AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        //Add Audio Source component to this Game Object when Start
        audio = gameObject.AddComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            audio.PlayOneShot(sound);
            Debug.Log("hit");
        }
    }
}
