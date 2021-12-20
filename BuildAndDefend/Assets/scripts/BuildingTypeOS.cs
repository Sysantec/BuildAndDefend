using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObjects/BuildingType")]
public class BuildingTypeOS : ScriptableObject
{
     public string nameString;
     public Transform Prefab;
     public ResourceGeneratorData resourceGeneratorData;
     
}
