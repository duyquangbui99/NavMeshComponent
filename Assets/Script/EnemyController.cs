using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent enemy;

    Animator anim;

    // Update is called once per frame
    void Update()
    {
        enemy.destination = player.position;
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("kick");

            ScoreLive.live -= 1;
        }
    }

}
