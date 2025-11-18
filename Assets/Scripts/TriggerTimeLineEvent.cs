using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeLineEvents: MonoBehaviour
{
    [Header("TimeLine")]
    public PlayableDirector Director;
    [Header("Monitors")]
    public GameObject[] screens;

    public bool hasPlayed = false;


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && !hasPlayed)
        {
            
            if(Director != null)
            {
                Director.Play();
            }
            hasPlayed = true;

        }
        foreach (GameObject monitor in screens)
        {
            monitor.SetActive(true);
        }
    }
}

