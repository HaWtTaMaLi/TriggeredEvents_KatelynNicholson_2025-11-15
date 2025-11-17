using UnityEngine;

public class TriggerDoorOpenClose : MonoBehaviour
{

    public Animator animatedObj;

    private void Start()
    {
        animatedObj.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animatedObj.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!animatedObj.enabled)
        {
            animatedObj.enabled = false; //haha funny, your trapped! 
        }
    }
}
