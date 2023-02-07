using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightOnOff : MonoBehaviour
{
    public GameObject FlashlightOnPlayer;
    public GameObject FlashlightNotOnPlayer;
    private bool FlashlightActive = true;

    void Start()
    {
        FlashlightOnPlayer.SetActive(false);
        FlashlightNotOnPlayer.SetActive(true);
    }
    void Update()
    {
        if (FlashlightNotOnPlayer.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (FlashlightActive == false)
                {
                    FlashlightOnPlayer.gameObject.SetActive(true);
                    FlashlightActive = true;
                }
                else
                {
                    FlashlightOnPlayer.gameObject.SetActive(false);
                    FlashlightActive = false;
                }
            }
        }
    }
}
