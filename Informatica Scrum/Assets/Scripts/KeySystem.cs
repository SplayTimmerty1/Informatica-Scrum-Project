using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeySystem : MonoBehaviour
{
    private bool keycollected = false;
    [SerializeField] private Text Collected;
    [SerializeField] private Text Unlocked;
    [SerializeField] private Text Locked;

    void Start()
    {
        keycollected = false;
        Collected.gameObject.SetActive(false);
        Unlocked.gameObject.SetActive(false);
        Locked.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Key") && Input.GetKey(KeyCode.E))
        {
            Destroy(collision.gameObject);
            keycollected = true;
            StartCoroutine(KeyCollectedText());
        }

        if (keycollected == true)
        {
            if (collision.gameObject.CompareTag("LockedDoor") && Input.GetKey(KeyCode.E))
            {
                print("you've unlocked this door");
                collision.gameObject.tag = "UnlockedDoor";
                StartCoroutine(DoorUnlockedText());
            }
        }
        else
        {
            if (collision.gameObject.CompareTag("LockedDoor") && Input.GetKey(KeyCode.E))
            {
                print("This door is Locked!");
                StartCoroutine(DoorLockedText());
            }
        }

        if (collision.gameObject.CompareTag("UnlockedDoor") && Input.GetKey(KeyCode.E))
        {
            //dit is waar uiteindelijk het script voor het openen van een deur moet komen
        }
    }

    

    IEnumerator KeyCollectedText()
    {
        Collected.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        Collected.gameObject.SetActive(false);
    }

    IEnumerator DoorUnlockedText()
    {
        Unlocked.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        Unlocked.gameObject.SetActive(false);
    }

    IEnumerator DoorLockedText()
    {
        Locked.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        Locked.gameObject.SetActive(false);
    }
}
