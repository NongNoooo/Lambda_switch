using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteSysyem : MonoBehaviour
{
    //��������Ʈ 3����
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
        //action �۵�
        sp();

        //����ġ������ ��������Ʈ ��ü
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

    //action �޾ƿ���
    public void Change(Action change)
    {
        sp = change;
    }
}
