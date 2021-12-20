using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
     private Dictionary<ResorceTypeOS, int> resourceAmountDictionary;

      
     private void Awake()
     {
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
     private void TestLogresourceAmountDictionary()
     {
           foreach(ResorceTypeOS resorceType in resourceAmountDictionary.Keys){
                Debug.Log(resorceType.nameString + " :" + resourceAmountDictionary[resorceType]);
           }
     }
}
