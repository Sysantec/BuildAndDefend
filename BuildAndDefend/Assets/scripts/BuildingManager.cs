using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    private Camera mainCamera;
    private BuildingTypeListOS buildingTypeList;
    private BuildingTypeOS buildingType;
    
 
    private void Start()
    {
        mainCamera =  Camera.main;

        //takeing tha objects from BuildingTypeListOS
        buildingTypeList = Resources.Load<BuildingTypeListOS>(typeof(BuildingTypeListOS).Name);
        buildingType = buildingTypeList.list[0];
    }
    private void Update()
    {
        // debug
          if(Input.GetMouseButtonDown(0))
          {
            Instantiate(buildingType.Prefab, GetMouseWorldPosition(), Quaternion.identity);
          }
          if(Input.GetKeyDown(KeyCode.S))
          {
              buildingType = buildingTypeList.list[1];
          }
          if(Input.GetKeyDown(KeyCode.W))
          {
              buildingType = buildingTypeList.list[0];
          }
    }
    // get Mouse position  
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
