using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyPress : MonoBehaviour
{
    [SerializeField] string _keyLetter;
    private string _textGerman;
    private ComputerBehaviour _computerBehaviour;
    private bool canType= true;
    private float waittime=1;

    private void Start()
    {
        _computerBehaviour = FindObjectOfType<ComputerBehaviour>();
    }

    public void OnLetterPress()
    {
        if (canType)
        {
            _textGerman = _computerBehaviour.TextTargetGerman.text + _keyLetter ;
            _computerBehaviour.TextTargetGerman.text = _textGerman;
            canType = false;
            Invoke(nameof(MakeCanTypeTrueAgain),waittime);
        }
        
    }

    public void OnDelete()
    {
        _computerBehaviour.TextTargetGerman.text = "";
    }

    void MakeCanTypeTrueAgain()
    {
        canType = true;
    }
}
