using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{

    public List<Item> itemList = new List<Item>();
    // Start is called before the first frame update
    public Dictionary<int,Item> itemDictionary = new Dictionary<int, Item>();
    void Start()
    {
        Item MySward = new Item();
        MySward.id = 0;
        MySward.name = "knife";
        Item MyBullet = new Item();
        MyBullet.name = "Bullet";
        MyBullet.id = 1;
        Item MyCar = new Item();
        MyCar.name = "Car";
        MyCar.id = 2;
        itemDictionary.Add(0, MySward);
        itemDictionary.Add(1, MyBullet);
        itemDictionary.Add(2, MyCar);
     /*   foreach(Item item in itemDictionary.Values)
        {
            Debug.Log("Value:" + item.name);
        }*/
        itemList.Add(MySward);
        itemList.Add(MyBullet);
        itemList.Add(MyCar);
       /* foreach(KeyValuePair<int,Item>item in itemDictionary)
        {
            Debug.Log("Key :" + item.Key);
            Debug.Log("Value :" + item.Value.name);
        }*/
        //itemDictionary[0];
        var myDictionaryItem = itemDictionary[1];
        Debug.Log(myDictionaryItem.name);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
