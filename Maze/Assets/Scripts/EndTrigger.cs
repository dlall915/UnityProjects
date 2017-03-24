using UnityEngine;

public class EndTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

    }
}
