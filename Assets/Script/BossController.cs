using UnityEngine;
using UnityEngine.AI;

public class BossController : MonoBehaviour
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
            anim.SetTrigger("punch");
            ScoreLive.live -= 1;
        }
    }
}
