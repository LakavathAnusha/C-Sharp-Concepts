using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColorWithDelegate : MonoBehaviour
{
    public delegate void ActionButonClick();
    public static event ActionButonClick onActionButtonClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CubeColorChange()
    {
        if(onActionButtonClick!=null)
        {
            onActionButtonClick();
        }
    }
}
