using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    public float runspeed = 10;

    void Update()
    {
        transform.Translate(Vector3.right * runspeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("limit"))
        {
            this.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("boss"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
