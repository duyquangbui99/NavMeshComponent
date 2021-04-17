using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class BossController : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent enemy;

    public GameObject falledEnemy;

    bool isfalled = false;

    Animator anim;


    void Update()
    {
        if (isfalled) // if fall stop enemy movement 
        {
            enemy.velocity = Vector3.zero;
        }
        else // if not keep following player
        {
            enemy.destination = player.position;
        }

        anim = GetComponent<Animator>();
    }

    public IEnumerator deathdelay()
    {
        yield return new WaitForSeconds(2f);
        falledEnemy.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("punch");
            ScoreLive.live -= 1;
        }

        if (other.gameObject.CompareTag("car"))
        {

            other.gameObject.SetActive(false);

            anim.SetTrigger("fall");
            isfalled = true;

            StartCoroutine(deathdelay());

            ScoreLive.enemylive -= 1;
        }
    }
}
