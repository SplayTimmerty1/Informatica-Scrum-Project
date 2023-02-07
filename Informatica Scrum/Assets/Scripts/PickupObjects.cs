using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    public GameObject ObjectOnPlayer;
    public GameObject ObjectNotOnPlayer;
    public bool PickedUp = false;

    void Start()
    {
        ObjectOnPlayer.SetActive(false);
        ObjectNotOnPlayer.SetActive(true);
        PickedUp = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            this.gameObject.SetActive(false);
            ObjectOnPlayer.SetActive(true);
            PickedUp = true;
        }
    }
}
