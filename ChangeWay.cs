using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWay : MonoBehaviour
{
    public GameObject Next;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Person"))
        {
            this.gameObject.SetActive(false);
            Next.SetActive(true);
        }
    }
}
