using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public Camera MainCamera;

    private void Update()
    {
        RaycastHit hitInfo;
        if(Physics.Raycast(MainCamera.ScreenPointToRay(Input.mousePosition), out hitInfo))
        {
            Debug.LogWarning(hitInfo.collider.name + " is hit");
        }
    }
}