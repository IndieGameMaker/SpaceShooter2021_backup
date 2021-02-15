using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    void Awake()
    {
        //제일 먼저 호출되는 함수
        //스크립트가 비활성화 되어 있어도 호출되는 함수
        Debug.Log("Awake 함수 실행");
    }

    void OnEnable()
    {
        //두번째로 호출되는 함수
        //스크립트가 활성화될 때 마다 호출되는 함수
        Debug.Log("OnEnable 함수 실행");
    }

    void Start()
    {
        //세번째로 호출되는 함수
        //Update 함수가 호출되기 전에 호출되는 함수
        //코루틴(Coroutine)으로 호출될 수 있는 함수 (예, IEnumerator Start() {})
        Debug.Log("Start 함수 실행");
    }

    void Update()
    {
        //프레임 마다 호출되는 함수
        //호출되는 간격이 불규칙적인 함수
        //화면의 랜더링 주기와 일치
    }

    void LateUpdate()
    {
        //Update 함수가 종료된 후 호출되는 함수
    }

    void FixedUpdate()
    {
        //일정한 간격으로 호출되는 함수(기본값 0.02초)
        //물리엔진의 계산 주기와 일치
    }
}
