using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComputerBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTargetEnglish, _textTargetGerman;
    [SerializeField] private GameObject _productTargetImage, _audioPlayerEn, _audioPlayerDe;
    private AudioSource sound; 

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SuperMarketGoods _superMarketGoods))
        {
            sound.Play();
            _textTargetEnglish.text = _superMarketGoods._nameEnglish;
            _textTargetGerman.text = _superMarketGoods._nameGerman;

        }
    }
}
