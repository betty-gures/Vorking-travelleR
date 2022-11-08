using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ArrowButtonVR : MonoBehaviour
{
    [SerializeField ]private Vector3 buttonPressedPosition;
    private Vector3 buttonInitialPosition;

    private GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    private GameObject presser;
    private AudioSource sound;
    private bool isPressed;
    
    void Start()
    {
        button = this.gameObject;
        buttonInitialPosition = button.transform.localPosition;
        //buttonPressedPosition = new Vector3(buttonInitialPosition.x, buttonInitialPosition.y , buttonInitialPosition.z- 0.2f);
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = buttonPressedPosition;
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = buttonInitialPosition;
            onRelease.Invoke();
            isPressed = false;
        }
    }
}
