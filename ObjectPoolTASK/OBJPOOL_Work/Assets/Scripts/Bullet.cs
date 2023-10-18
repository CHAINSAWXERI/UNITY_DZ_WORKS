using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifetime = 5;
    private float _currLifeTime;
    private ObjectPoool _owner;

    public void SetOwner(ObjectPoool owner)
    {
        _owner = owner;
    }

    private void OnEnable()
    {
        _currLifeTime = lifetime;
    }
    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        _currLifeTime -= Time.deltaTime;
        if (_currLifeTime <= 0)
        {
            _owner.ReturnToPool(gameObject);
        }
    }
}
