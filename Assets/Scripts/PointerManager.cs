using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class PointerManager : MonoBehaviour, IMixedRealityFocusHandler, IMixedRealityPointerHandler
{
    public Transform heartObject;
    public bool isRotate;

    public void OnFocusEnter(FocusEventData eventData)
    {
        Debug.Log("포커스 인");
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        Debug.Log("포커스 아웃");
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        Debug.Log("포인터 클릭 이벤트");
        isRotate = !isRotate;
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        Debug.Log("포인터 다운 이벤트");
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        Debug.Log("포인터 드래그 이벤트");
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        Debug.Log("포인터 업 이벤트");
    }

    public void ShowMessage(string msg)
    {
        print(msg);

        if (msg == "클릭")
        {
            isRotate = !isRotate;
        }
    }

    void Update()
    {
        if (isRotate == false) return;

        heartObject.Rotate(Vector3.up * Time.deltaTime * 100.0f);
    }
}
