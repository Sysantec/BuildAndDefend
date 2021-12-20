using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
     public static ResourceManager Instance{get; private set;}
     private Dictionary<ResorceTypeOS, int> resourceAmountDictionary;

      
     private void Awake()
     {
          Instance = this;
         resourceAmountDictionary = new Dictionary<ResorceTypeOS, int>();

         // geting the list of resources
         ResorceTypeListOS resorceTypeList = Resources.Load<ResorceTypeListOS>(typeof(ResorceTypeListOS).Name);

          //Cycle through list 
          foreach(ResorceTypeOS resorceType in resorceTypeList.list)
          {
               resourceAmountDictionary[resorceType] = 0;
          }
          TestLogresourceAmountDictionary();
     }
          //debuging
     private void Update()
     {
         if(Input.GetKeyDown(KeyCode.Q))
         {
              ResorceTypeListOS resorceTypeList = Resources.Load<ResorceTypeListOS>(typeof(ResorceTypeListOS).Name);
              addResources(resorceTypeList.list[0], 2);
              TestLogresourceAmountDictionary();
         }
     }
          //more debuging 
     private void TestLogresourceAmountDictionary()
     {
           foreach(ResorceTypeOS resorceType in resourceAmountDictionary.Keys){
                Debug.Log(resorceType.nameString + " :" + resourceAmountDictionary[resorceType]);
           }
     }
     //adding resource 
     public void addResources(ResorceTypeOS resorceType, int amount)
     {
          TestLogresourceAmountDictionary();
          resourceAmountDictionary[resorceType] += amount;
     }
}
