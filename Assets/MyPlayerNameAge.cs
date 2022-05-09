using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerNameAge : MonoBehaviour
{
    public Dictionary<string, int> footballPlayers = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        footballPlayers.Add("Anusha", 20);
        footballPlayers.Add("Vineeth", 22);
        footballPlayers.Add("Sunil", 30);
        var foodballPlayerAge = footballPlayers["Vineeth"];
        Debug.Log(foodballPlayerAge);
        foreach(KeyValuePair<string,int> item in footballPlayers)
        {
            Debug.Log("Player age:"+item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
