using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponBehavior : MonoBehaviour
{
    public WeaponScriptableObject weaponData;
    protected Vector3 direction;
    public float destroyAfterSeconds = 5f;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirx = direction.x;
        float diry = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        // default rotation is for right

        if (dirx < 0 && diry == 0) // left
        {
            scale.x *= -1;
            scale.y *= -1;
        }
        else if (dirx > 0 && diry == 0) // right
        {
            scale.x *= 1;
            scale.y *= 1;
        }
        else if (dirx == 0 && diry > 0) // up
        {
            scale.x *= -1;
        }
        else if (dirx == 0 && diry < 0) // down
        {
            scale.y *= -1;
        }
        else if (dirx < 0 && diry > 0) // up left
        {
            scale.x *= -1;
            scale.y *= -1;
            rotation.z = -90;
        }
        else if (dirx > 0 && diry > 0) // up right
        {
            rotation.z = 0;
        }
        else if (dirx < 0 && diry < 0) // down left
        {
            scale.x *= -1;
            scale.y *= -1;
            rotation.z = 0;
        }
        else if (dirx > 0 && diry < 0) // down right
        {
            rotation.z = -90;
        }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
