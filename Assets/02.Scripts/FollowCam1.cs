using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam1 : MonoBehaviour
{
    public Transform targetTr;
    private Transform camTr;

    [Range(2.0f, 20.0f)]
    public float distance = 10.0f;
    [Range(0.0f, 10.0f)]
    public float height = 2.0f;

    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        //추적해야 할 대상의 뒷쪽으로 distance 만큼 이동
        //높이를 height 만큼 이동
        camTr.position = targetTr.position
                         + (-targetTr.forward * distance)
                         + (Vector3.up * height);

        //Camera를 피봇좌표를 향해 회전
        camTr.LookAt(targetTr.position);
    }
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform targetTr;
    private Transform camTr;

    [Range(2.0f, 20.0f)]
    public float distance = 10.0f;
    [Range(0.0f, 10.0f)]
    public float height = 2.0f;

    public float damping = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        //추적해야 할 대상의 뒷쪽으로 distance 만큼 이동
        Vector3 pos = targetTr.position + (-targetTr.forward * distance) + (Vector3.up * height);
        camTr.position = Vector3.Slerp(camTr.position, pos, Time.deltaTime * damping);

        //height 만큼 Y축으로 이동
        //camTr.position += Vector3.up * height;

        //Camera를 피봇좌표를 향해 회전
        camTr.LookAt(targetTr.position);
    }
}


*/
