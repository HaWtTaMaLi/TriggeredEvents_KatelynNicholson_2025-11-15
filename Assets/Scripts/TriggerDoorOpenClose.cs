using UnityEngine;

public class TriggerDoorOpenClose : MonoBehaviour
{

    public Animator animatedObj;
    public AudioSource openDoor;

    public bool hasPlayed = false;

    private void Start()
    {
        animatedObj.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayed)
        {
            animatedObj.enabled = true;
            
            if (openDoor != null )
            {
                openDoor.Play();
            }

            hasPlayed = true; //OneShot
        }
    }
}
