using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 0f;
    public Transform target;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffset, -10f);
        newPos = Vector3.Lerp(transform.position, newPos, FollowSpeed * Time.deltaTime);

        transform.position = newPos;
    }
}
