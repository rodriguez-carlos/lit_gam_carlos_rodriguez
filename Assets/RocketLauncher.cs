using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    public Transform spawnPoint;
    
    public GameObject MissilePrefab;

    public void Start()
    {
        var newMissile = Instantiate(MissilePrefab, spawnPoint.position, spawnPoint.rotation);

        newMissile.transform.parent = gameObject.transform;
    }
}
