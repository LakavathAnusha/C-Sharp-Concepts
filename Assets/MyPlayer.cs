using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public Dictionary<int, Player> playersDictionary = new Dictionary<int, Player>();
    // Start is called before the first frame update
    void Start()
    {
        Player playerOne = new Player(13);
        playerOne.name = "Anusha";
             Player playerTwo = new Player(20);
        playerOne.name = "Vineeth";
        Player playerThree = new Player(16);
        playerOne.name = "Sunil";
        playersDictionary.Add(playerOne.id,playerOne);
        playersDictionary.Add(playerTwo.id, playerTwo);
        playersDictionary.Add(playerThree.id, playerThree);
        var myDictionary = playersDictionary[playerTwo.id];
        Debug.Log("name :" +myDictionary.name);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var myDictionary=playersDictionary[20];
            Debug.Log("name :"+myDictionary.name);
        }
    }
}
