using System;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public spriteSysyem ss;

    //딕셔너리로 키입력 받기
    //          키값  키에 따른 값(value)
    Dictionary<KeyCode, Action> keyDic;

    private void Start()
    {
        DictionaryKey();
    }

    //키입력과 키입력시 작동할 action
    void DictionaryKey()
    {
        keyDic = new Dictionary<KeyCode, Action>
        {
            {KeyCode.Q, () => ss.Change(() => ss.s = spriteSysyem.sprite.squa) },
            {KeyCode.W, () => ss.Change(() => ss.s = spriteSysyem.sprite.cir) },
            {KeyCode.E, keyDownE }
        };
    }

    void keyDownE()
    {
        ss.Change(() => ss.s = spriteSysyem.sprite.cap);
    }



    private void Update()
    {
        KeyInput();
    }
    
    void KeyInput()
    {
        if (Input.anyKey)
        {
            foreach (var dic in keyDic)
            {
                if (Input.GetKey(dic.Key))
                {
                    dic.Value();
                }
            }
        }
    }
}
