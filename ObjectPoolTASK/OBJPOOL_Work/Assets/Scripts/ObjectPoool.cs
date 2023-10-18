using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoool : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    [SerializeField] private int pooolSize;

    private List<GameObject> bullets;

    private void Awake()
    {
        InitPool();
    }

    private void InitPool()
    {
        bullets = new List<GameObject>();
        for (int i = 0; i < pooolSize; i++)
        {
            GameObject bulletInstance = Instantiate(prefabBullet, transform);
            if (bulletInstance.TryGetComponent(out Bullet bullet))
            {
                bullet.SetOwner(this);
            }
            ReturnToPool(bulletInstance);
        }
    }

    public bool TryGetFromPool(out GameObject bulletInstance)
    {
        bulletInstance = null;
        if (bullets.Count > 0)
        {
            bulletInstance = bullets[0];
            bulletInstance.SetActive(true);
            bullets.RemoveAt(0); 
            return true;
        }
        return false;
    }

    public void ReturnToPool(GameObject bulletInstance)
    {
        bulletInstance.SetActive(false);
        bullets.Add(bulletInstance);
    }
}
