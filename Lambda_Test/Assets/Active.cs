using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public spriteSysyem ss;

    private void Update()
    {
        //Ű�Է����� Action ��� ����
        if (Input.GetKey(KeyCode.Q))
        {
            ss.Change(() => ss.s = spriteSysyem.sprite.squa);
        }
        if (Input.GetKey(KeyCode.W))
        {
            ss.Change(() => ss.s = spriteSysyem.sprite.cir);
        }
        if (Input.GetKey(KeyCode.E))
        {
            ss.Change(() => ss.s = spriteSysyem.sprite.cap);
        }

    }

}
