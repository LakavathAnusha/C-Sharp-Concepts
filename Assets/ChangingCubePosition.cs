using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingCubePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MainScript.onActionClick += ChangePosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangePosition()
    {
        transform.position = new Vector3(5f, 5f, 5f);
    }
}
