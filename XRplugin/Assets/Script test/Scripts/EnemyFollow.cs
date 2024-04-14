using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public XROrigin player;
    public Vector3 playerpos;
    public float movespeed;
    
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        playerpos = player.transform.position;

        transform.position = Vector3.MoveTowards(transform.position, playerpos, movespeed * Time.deltaTime);
    }
}
