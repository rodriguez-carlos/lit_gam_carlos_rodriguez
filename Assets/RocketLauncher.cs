using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject MissilePrefab;

    private GameObject newMissile;

    public RocketLauncherData rocketLauncherData;

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (newMissile != null)
                Destroy(newMissile);
            
            newMissile = Instantiate(MissilePrefab, spawnPoint.position, spawnPoint.rotation);

            newMissile.transform.parent = gameObject.transform;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(newMissile != null)
            {
                var missileRb = newMissile.AddComponent<Rigidbody>();
                missileRb.isKinematic = false;
                Vector3 forceDirection = spawnPoint.right * rocketLauncherData.range;
                missileRb.AddForce(forceDirection, ForceMode.Impulse);
                Destroy(newMissile, 3);
            }
        }
    }
}
