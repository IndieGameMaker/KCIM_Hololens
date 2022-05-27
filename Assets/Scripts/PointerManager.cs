using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerManager : MonoBehaviour
{
    public Transform heartObject;
    public bool isRotate;

    public void ShowMessage(string msg)
    {
        print(msg);

        if (msg == "클릭")
        {
            isRotate = !isRotate;
        }
    }
}
