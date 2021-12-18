using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField] private Transform Building;
 
    private void Start()
    {
        mainCamera =  Camera.main;
    }
    private void Update()
    {
          if(Input.GetMouseButtonDown(0))
          {
            Instantiate(Building, GetMouseWorldPosition(), Quaternion.identity);
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
