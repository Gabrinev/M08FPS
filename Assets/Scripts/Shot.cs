using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;

    public float shotForce = 1500;
    public float shotRate = 0.5f;
    public float boostTimer;
    public bool boosting;

    private float shotRateTime = 0;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            if (Time.time>shotRateTime)
            {
                GameObject newBullet;
                newBullet = Instantiate(bullet,spawnPoint.position, spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBullet,2);
            }
        }
        if (boosting)
        {
            boostTimer = Time.deltaTime;
            if (boostTimer >= 3)
            {
                shotRate = 0.5f;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        if (collision.collider.CompareTag("AttackSpeedBoost"))
        {
            boosting = true;
            shotRate = 0.3f;

            
        }
    }
}
