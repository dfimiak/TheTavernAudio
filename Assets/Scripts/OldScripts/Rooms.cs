using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    public RoomAmbient roomAmbient;

    private void OnTriggerStay(Collider other)
    {
        roomAmbient.ambientActivated = true;
    }

    private void OnTriggerExit(Collider other)
    {
        roomAmbient.ambientActivated = false;
    }
}
