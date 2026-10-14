using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugWheel : MonoBehaviour
{
    public Transform busBody;
    public Vector3 defaultLocalPos;
    public float returnSpeed = 5f;
    public float maxUp = 0.2f;
    public float maxDown = 0.3f;

    void Start()
    {
        defaultLocalPos = transform.localPosition;
    }

    void Update()
    {
        Vector3 targetPos = defaultLocalPos;

        // efek goyang berdasarkan rotasi body
        float bodyTilt = busBody.eulerAngles.z;

        if (bodyTilt > 180) bodyTilt -= 360;

        float offsetY = -bodyTilt * 0.005f;

        offsetY = Mathf.Clamp(offsetY, -maxDown, maxUp);

        targetPos.y += offsetY;

        transform.localPosition = Vector3.Lerp(
            transform.localPosition,
            targetPos,
            Time.deltaTime * returnSpeed
        );
    }
}
