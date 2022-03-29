using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //action사용시 필요

public class Timer : MonoBehaviour
{
    private float time;
    public Action move;

    //다른 스크립트에서 시간과 기능을 할당 가능
    public void TimeToMove(float _time, Action _move)
    {
        time = _time;

        //move에 Action _move추가
        move += _move;
    }


    void Update()
    {
        //입력받은 시간 감소
        time -= Time.deltaTime;

        //시간이 0보다 크면 아래 기능 작동
        if(isTIme()) move();
    }

    public bool isTIme()
    {
        Debug.Log(isTIme());
        return time > 0;
    }

}
