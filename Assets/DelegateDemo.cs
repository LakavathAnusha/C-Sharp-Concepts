using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateDemo : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onChangeColor;
    public delegate void OnComplete();
    public OnComplete onChangeComplete;
    // Start is called before the first frame update
    void Start()
    {
        onChangeColor = UpdateColor;
        onChangeColor(Color.red);
        onChangeComplete += TaskComplete;
        onChangeComplete+=TaskOneCompleted;
        onChangeComplete += TaskTwoCompleted;
        if(onChangeComplete!=null)
        onChangeComplete();


    }

    private void TaskComplete()
    {
        Debug.Log("task Complete");
    }

    private void UpdateColor(Color newColor)
    {
        Debug.Log("Changing color to :" + newColor.ToString());
    }
    private void TaskOneCompleted()
    {
        Debug.Log("Task one Completed");
    }
    private void TaskTwoCompleted()
    {
        Debug.Log("Task two Completed");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
