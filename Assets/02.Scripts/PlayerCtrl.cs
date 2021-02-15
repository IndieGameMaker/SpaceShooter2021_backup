using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    //접근해야 하는 컴포넌트는 반드시 변수에 할당한 후 사용
    private Transform tr;
    //이동 속도 변수(public으로 선언되어 Inspector에 노출됨)
    public float moveSpeed = 10.0f;

    void Start()
    {
        //스크립트가 실행된 후 처음 수행되는 Start 함수에서 Transform 컴포넌트를 할당
        tr = this.gameObject.GetComponent<Transform>();      
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Debug.Log("h=" + h);
        Debug.Log("v=" + v);

        //Translate(이동 방향 * 속도 * 변위값 * Time.deltaTime, 기준좌표)
        tr.Translate(Vector3.forward * moveSpeed * v * Time.deltaTime, Space.Self);
    }
}