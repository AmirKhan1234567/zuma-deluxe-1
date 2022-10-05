using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public GameObject[] playerball;
    private int index;
    void Start()
    {
        playercamera = Camera.main;
    }
    void Update()
    {
        var lookposition = Input.mousePosition;
        lookposition.z = playercamera.transform.position.y - transform.position.y;
        lookposition = playercamera.ScreenToWorldPoint(lookposition);
        transform.forward = lookposition - transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            index = Random.Range(0, playerball.Length);
            spawningplayerfire();
        }
    }
    Camera playercamera;
    void spawningplayerfire()
    {
        Instantiate(playerball[index], transform.position, transform.rotation, transform.parent);
    }
}
