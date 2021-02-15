using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    //컴포넌트를 캐시 처리할 변수
    private Transform tr;
    //이동 속도 변수(public으로 선언되어 인스펙터 뷰에 노출됨)
    public float moveSpeed = 10.0f;

    void Start()
    {
        //컴포넌트를 추출해 변수에 대입
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Debug.Log("h=" + h);
        Debug.Log("v=" + v);

        //정규화 벡터를 사용한 코드
        //tr.position += Vector3.forward * 1;

        //Translate 함수를 사용한 이동 로직
        tr.Translate(Vector3.forward * Time.deltaTime * v * moveSpeed);
    }
}