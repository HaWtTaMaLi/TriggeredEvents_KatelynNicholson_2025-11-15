using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeLineEvents: MonoBehaviour
{

    public PlayableDirector timeline;
    //turn on monitors somewhere in here


    void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }

}

