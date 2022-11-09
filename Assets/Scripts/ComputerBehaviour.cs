using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ComputerBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTargetEnglish, _textTargetGerman;
    [SerializeField] private Image _productTargetImage;
    [SerializeField] private AudioSource _audioPlayerEn, _audioPlayerDe;
    private AudioSource sound;
    private bool isPressed;
    private GameObject presser;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((!isPressed)&&(other.TryGetComponent(out SuperMarketGoods _superMarketGoods)))
        {
            sound.Play();
            presser = other.gameObject;
            _textTargetEnglish.text = _superMarketGoods._nameEnglish;
            _textTargetGerman.text = _superMarketGoods._nameGerman;
            _productTargetImage.sprite = _superMarketGoods._productImage;
            _audioPlayerEn.clip = _superMarketGoods._pronounciaitonEnglish;
            _audioPlayerEn.clip = _superMarketGoods._pronounciaitonGerman;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            isPressed = false;
        }
    }
    
}
