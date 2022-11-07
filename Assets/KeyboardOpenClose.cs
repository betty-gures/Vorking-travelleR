using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardOpenClose : MonoBehaviour
{
    [SerializeField] private GameObject KeyboardLeft;
    [SerializeField] private GameObject KeyboardRight;

    public void OpenKeyboard()
    {
        KeyboardLeft.SetActive(true);
        KeyboardRight.SetActive(true);
    }
    public void CloseKeyboard()
    {
        KeyboardLeft.SetActive(false);
        KeyboardRight.SetActive(false);
    }

}
