using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform player;
    UnityEngine.AI.NavMeshAgent nav;
    Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        if (collision.collider.CompareTag("bala"))
        {
            Destroy(collision.gameObject);

            
        }
    }

    
}
