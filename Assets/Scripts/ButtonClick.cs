using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Text txt;
    private int cnt = 0;
    public void Click()
    {
        cnt += 1;
        txt.text = cnt.ToString();
    }
}
