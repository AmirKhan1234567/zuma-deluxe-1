using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour
{
    public GameObject explosionParticle;
    void Start()
    {
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("green"))
        {
            Instantiate(explosionParticle, transform.position, transform.rotation);
            spawnmanager.Instance.Add();
            spawnmanager.Instance.playAudio();
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }
}
