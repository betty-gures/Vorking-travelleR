using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ComputerBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTargetEnglish;
    public TextMeshProUGUI TextTargetGerman;
    [SerializeField] private Image _productTargetImage;
    [SerializeField] private AudioSource _audioPlayerEn, _audioPlayerDe;
    [SerializeField] private GameObject correct,notCorrect;
    
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
            _audioPlayerEn.clip = _superMarketGoods._pronounciaitonEnglish;
            _audioPlayerDe.clip = _superMarketGoods._pronounciaitonGerman;
            _productTargetImage.sprite = _superMarketGoods._productImage;
            if (!_superMarketGoods.isIncorrect)
            {
                TextTargetGerman.text = _superMarketGoods._nameGerman;
                correct.SetActive(true);
                notCorrect.SetActive(false);  
            }
            else
            {
                TextTargetGerman.text = "?";
                correct.SetActive(false);
                notCorrect.SetActive(true); 
            }
            
        }
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            isPressed = false;
        }
    }

    public void OnEnter()
    {
        correct.SetActive(true);
        notCorrect.SetActive(false);
    }
    
}
