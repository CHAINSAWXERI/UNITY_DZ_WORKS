using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShooter : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private ObjectPoool bulletPool;
    private void Shoot()
    {
        if (bulletPool.TryGetFromPool(out GameObject bulletInstance))
        {
            bulletInstance.transform.position = firePoint.transform.position;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot();
        }
    }
}
