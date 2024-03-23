using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public RectTransform experienceValueRectTransform;
    public TextMeshProUGUI levelValueTMP;

    private float _experienceCurrentValue = 0;
    private float _experienceTargetValue = 100;

    private int _levelValue = 1;

    private void Start()
    {
        DrawUI();
    }
    public void AddExperience(float value)
    {
        _experienceCurrentValue += value;
        if(_experienceCurrentValue >= _experienceTargetValue)
        {
            _levelValue++;
            _experienceCurrentValue = 0;
        }
        DrawUI();
    }
    private void DrawUI()
    {
        experienceValueRectTransform.anchorMax = new Vector2(_experienceCurrentValue / _experienceTargetValue, 1);
        levelValueTMP.text = _levelValue.ToString();
    }
}
