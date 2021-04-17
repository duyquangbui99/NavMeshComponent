using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alien : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent enemy;

    public GameObject lowman;

    int Alienlive = 3;

    Animator anim;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(runDelay());
        anim = GetComponent<Animator>();
    }

    public IEnumerator runDelay()
    {
        yield return new WaitForSeconds(10f);
        enemy.destination = player.position;
    }

    public IEnumerator deathdelay()
    {
        yield return new WaitForSeconds(1f);
        lowman.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("attack");
            StartCoroutine(deathdelay());
            Debug.Log("alien hit");
        }

        if (other.gameObject.CompareTag("car"))
        {
            Alienlive -= 1;
            if(Alienlive == 0)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
