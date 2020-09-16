using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerControl : MonoBehaviour
{
    public float damage = 1;
    public float range = 1000;
    public LayerMask layer;

    public Camera cam;
    public static event Action<PlayerControl> OnAttack;
    

    void Start()
    {
        //enemy = GameObject.Find("Enemy");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    void Attack()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast (ray, out hit, range, layer))
        {
            Debug.Log("Hit Something");
            //OnAttack();
        }

    }
}
