using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent nm;
    private Transform target;
    public Health playerHealth;

    public enum AIState { iddle, chasing, attacking};
    public AIState aiState = AIState.iddle;

    public float distanceThreshold = 5f;
    
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;

    StartCoroutine(Think());

    }

    // Update is called once per frame

    IEnumerator Think()
    {
        while (true)
        {
            switch (aiState)
            {
                case AIState.iddle:
                    float distance = Vector3.Distance(target.position, transform.position);
                    if (distance < distanceThreshold)
                    {
                        aiState = AIState.chasing;
                        animator.SetBool("Chasing", true);
                    }
                    nm.SetDestination(transform.position);
                    break;
                case AIState.chasing:
                    distance = Vector3.Distance(target.position, transform.position);
                    if(distance < 2f)
                    {
                        aiState = AIState.attacking;
                        animator.SetBool("Attacking", true);
                    }
                    if (distance > distanceThreshold && distance > 2f)
                    {
                        aiState = AIState.iddle;
                        animator.SetBool("Chasing", false);
                    }
                    nm.SetDestination(target.position);
                    break;
                case AIState.attacking:
                    distance = Vector3.Distance(target.position, transform.position);
                    if (distance > 2f)
                    {
                        aiState = AIState.chasing;
                        animator.SetBool("Attacking", false);
                    }
                    playerHealth.TakeDamage(5);
                    nm.SetDestination(transform.position);
                    break;
                default:
                    break;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
