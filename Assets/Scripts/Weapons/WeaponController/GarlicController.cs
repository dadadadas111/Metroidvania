using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicController : WeaponController
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawned = Instantiate(prefab);
        spawned.transform.position = transform.position;
        spawned.transform.parent = transform;
    }
}
