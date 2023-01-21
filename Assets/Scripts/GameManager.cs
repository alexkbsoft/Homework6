using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region public
    public float TimeLimitInSeconds = 10.0f;
    public Pin pin1;
    public Pin pin2;
    public Pin pin3;

    public Impact winCombination;
    public Impact startingValue;
    
    #endregion

    #region private
    [SerializeField]
    private TextMeshProUGUI _titleElement;

    [SerializeField]
    private TextMeshProUGUI _timerElement;

    [SerializeField]
    private GameObject _msgBox;
    [SerializeField]
    private GameObject _gameCanvas;
    private float _timeElapsed = 0;
    #endregion

    void Start()
    {
        Reset();
    }

    void Update()
    {
        _timeElapsed -= Time.deltaTime;
        _timerElement.text = Mathf.CeilToInt(_timeElapsed).ToString("D");

        if (_timeElapsed <= 0)
        {
            ShowFinalScreen("Вы проиграли");
        }
    }

    public void ToolPressed(Impact impactVal)
    {
        if (pin1.IsValid(impactVal.pin1) &&
            pin2.IsValid(impactVal.pin2) && 
            pin3.IsValid(impactVal.pin3))
        {
            pin1.IncrementValue(impactVal.pin1);
            pin2.IncrementValue(impactVal.pin2);
            pin3.IncrementValue(impactVal.pin3);
        }


        if (IsWinCombination() && _msgBox != null)
        {
            ShowFinalScreen("Вы выиграли");
        }
    }

    public void Reset()
    {
        pin1.CurrentValue = startingValue.pin1;
        pin2.CurrentValue = startingValue.pin2;
        pin3.CurrentValue = startingValue.pin3;

        _msgBox.SetActive(false);
        _gameCanvas.SetActive(true);
        _timeElapsed = TimeLimitInSeconds;
    }

    private void ShowFinalScreen(string text)
    {
        _titleElement.text = text;
        _msgBox.SetActive(true);
        _gameCanvas.SetActive(false);
    }

    private bool IsWinCombination() => pin1.CurrentValue == winCombination.pin1 &&
        pin2.CurrentValue == winCombination.pin2 &&
        pin3.CurrentValue == winCombination.pin3;
}
