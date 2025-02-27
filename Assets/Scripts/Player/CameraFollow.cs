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
        // newPos = Vector3.Lerp(transform.position, newPos, FollowSpeed * Time.deltaTime);

        // the above line make the camera follow the player with a delay, which is smooth but the pixel art will be blurry
        // so we improrve it by using the below line

        transform.position = newPos;
    }
}
