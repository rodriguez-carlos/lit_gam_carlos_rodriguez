using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject MissilePrefab;

    private GameObject newMissile;

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            newMissile = Instantiate(MissilePrefab, spawnPoint.position, spawnPoint.rotation);

            newMissile.transform.parent = gameObject.transform;

        }

        if (Input.GetMouseButtonDown(0))
        {
            if(newMissile != null)
            {
                var missileRb = newMissile.AddComponent<Rigidbody>();

                missileRb.AddForce(new Vector3(spawnPoint.rotation.x, spawnPoint.rotation.y) * 1000f, ForceMode.Force);
                Destroy(newMissile, 3);
            }
        }
    }
}
