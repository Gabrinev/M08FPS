using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBuff : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        if (collision.collider.CompareTag("Player"))
        {
            
            Destroy(this.gameObject);

            
        }
    }
}
