
using UnityEngine;

public class Car : MonoBehaviour
{
    public float runspeed = 10;
 
    void Update()
    {
        transform.Translate(Vector3.forward * runspeed * Time.deltaTime);
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
