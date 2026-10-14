using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 3f;
    public Vector3 offset = new Vector3(3f, 2f, -10f);

    public float minX;
    public float maxX;

    public float minY;
    public float maxY;

    void LateUpdate()
    {
        if (target == null) return;

        float targetX = target.position.x + offset.x;
        float targetY = target.position.y + offset.y;

        // Clamp batas map
        targetX = Mathf.Clamp(targetX, minX, maxX);
        targetY = Mathf.Clamp(targetY, minY, maxY);

        Vector3 desiredPos = new Vector3(
            targetX,
            targetY,
            offset.z
        );

        Vector3 smoothPos = Vector3.Lerp(
            transform.position,
            desiredPos,
            smoothSpeed * Time.deltaTime
        );

        transform.position = smoothPos;
    }
}