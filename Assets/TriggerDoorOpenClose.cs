using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class TriggerDoorOpenClose : MonoBehaviour
{

    public Animator animatedObj;
    public string doorTrigger = "ActivateDoor";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (animatedObj != null)
            {
                animatedObj.SetTrigger("ActivateDoor");
            }
        }
    }

}
