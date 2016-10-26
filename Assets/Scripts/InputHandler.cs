using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Camera MainCamera;

    public void OnPointerEnter()
    {
        Debug.Log(gameObject.name + " pointer enter.");
    }

    public void OnPointerExit()
    {
        Debug.Log(gameObject.name + " pointer exit.");
    }

    public void OnDragBegin()
    {
        Debug.Log(gameObject.name + " drag start.");
    }

    public void OnDrag()
    {
        Ray screenRay = MainCamera.ScreenPointToRay(Input.mousePosition);
        transform.position = MainCamera.transform.position + screenRay.direction*10;
    }

    public void OnDragEnd()
    {
        Debug.Log(gameObject.name + " drag end.");
    }
}