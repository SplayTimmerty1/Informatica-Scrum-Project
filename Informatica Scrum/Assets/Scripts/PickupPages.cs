using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupPages : MonoBehaviour
{
    private int Pages = 0;

    [SerializeField] private Text pagesText;

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Page") && Input.GetKey(KeyCode.E))
        {
            Destroy(collision.gameObject);
            Pages++;
            pagesText.text = "Pages Collected:" + Pages;
        }
    }

    void Update()
    {
        if(Pages == 6)
        {
            StartCoroutine(FinishPages());
        }
    }

    IEnumerator FinishPages()
    {
        yield return new WaitForSeconds(2);
        pagesText.text = "Congratulations, you've collected all pages!";
        yield return new WaitForSeconds(5);
        pagesText.gameObject.SetActive(false);
    }
}
