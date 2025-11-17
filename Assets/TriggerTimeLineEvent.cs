using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeLineEvents: MonoBehaviour
{

    public PlayableDirector timeline;

    void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }

}

