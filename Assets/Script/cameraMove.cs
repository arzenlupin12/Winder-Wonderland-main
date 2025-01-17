using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothcamera;
    public Vector3 minValue, maxValue;
    // Update is called once per frame
    void FixedUpdate()
    {
        Camera();
    }

    private void Camera()
    {
        Vector3 Player = player.position + offset;
        Vector3 Bound = new Vector3(
           Mathf.Clamp(player.position.x, minValue.x, maxValue.x),
           Mathf.Clamp(player.position.y, minValue.y, maxValue.y),
           Mathf.Clamp(player.position.z, minValue.z, maxValue.z));
        Vector3 smooth = Vector3.Lerp(transform.position, Bound, smoothcamera * Time.fixedDeltaTime);
        transform.position = smooth;
    }
}
