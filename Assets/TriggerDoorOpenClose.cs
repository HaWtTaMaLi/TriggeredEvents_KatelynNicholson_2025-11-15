using UnityEngine;
using UnityEngine.Playables;

public class TriggerDoorOpenClose : MonoBehaviour
{

    public PlayableDirector timeline;

    void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }

    // Alternate one time trigger implementation 
    // (trigger will self-destruct after initating timeline)

    /*
     
    void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        Destroy(this.gameObject);
    }

    */

}
