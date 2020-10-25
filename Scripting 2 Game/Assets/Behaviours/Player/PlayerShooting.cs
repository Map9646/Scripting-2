using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int ammoCount = 20;
    public int maxAmmo = 20; 
    public GameObject prefab;
    private float bulletForce;
    public Transform instancer;
    public WaitForSeconds reloadTime;
    
    private void Start()
    {
        reloadTime = new WaitForSeconds(2f);
        ammoCount = maxAmmo; 
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammoCount >= 0)
        {
            StartCoroutine(Fire());
        }
    }


    private IEnumerator Fire()
    {
        Instantiate(prefab, instancer.position, instancer.rotation);
        ammoCount--;

        if (ammoCount == 0) yield break; 
        {
            yield return reloadTime;
            ammoCount = maxAmmo;
        }
    }
}
