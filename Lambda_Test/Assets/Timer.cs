using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //action���� �ʿ�

public class Timer : MonoBehaviour
{
    private float time;
    public Action move;

    //�ٸ� ��ũ��Ʈ���� �ð��� ����� �Ҵ� ����
    public void TimeToMove(float _time, Action _move)
    {
        time = _time;

        //move�� Action _move�߰�
        move += _move;
    }


    void Update()
    {
        //�Է¹��� �ð� ����
        time -= Time.deltaTime;

        //�ð��� 0���� ũ�� �Ʒ� ��� �۵�
        if(isTIme()) move();
    }

    public bool isTIme()
    {
        Debug.Log(isTIme());
        return time > 0;
    }

}
