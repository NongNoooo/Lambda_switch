using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteSysyem : MonoBehaviour
{
    //스프라이트 3종류
    public GameObject squa;
    public GameObject Circ;
    public GameObject Cap;

    public enum sprite
    {
        squa,
        cir,
        cap,
    }

    //enum
    public sprite s;

    Action sp;
`
    void Update()
    {
        //action 작동
        sp();

        //스위치문으로 스프라이트 교체
        switch (s)
        {
            case sprite.squa:
                squa.SetActive(true);
                Circ.SetActive(false);
                Cap.SetActive(false);
                break;
            case sprite.cir:
                squa.SetActive(false);
                Circ.SetActive(true);
                Cap.SetActive(false);
                break;
            case sprite.cap:
                squa.SetActive(false);
                Circ.SetActive(false);
                Cap.SetActive(true);
                break;
        }
    }

    //action 받아오기
    public void Change(Action change)
    {
        sp = change;
    }
}
