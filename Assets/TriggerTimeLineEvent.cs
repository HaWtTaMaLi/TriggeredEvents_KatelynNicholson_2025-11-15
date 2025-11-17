using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeLineEvents: MonoBehaviour
{
    [Header("TimeLine")]
    public PlayableDirector Director;
    [Header("Monitors")]
    public GameObject[] screens;


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Director.Play();
            //target object tag = Monitors
            //setactive object tagged with Monitors 
        }
        foreach (GameObject monitor in screens)
        {
            monitor.SetActive(true);
        }
    }
}

