using TMPro;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private CarInaformation _info;
    
    private RectTransform _infoPanel;
    private TMP_Text _infoText;

    public CarInaformation Info => _info;

    private void OnMouseDown()
    {
        _infoPanel.gameObject.SetActive(!_infoPanel.gameObject.activeInHierarchy);
    }

    public void OnCreate(RectTransform infoPanel, TMP_Text infoText)
    {
        _infoPanel = infoPanel;
        _infoText = infoText;
    }

    public void Show()
    {
        gameObject.SetActive(true);
        EditText();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void EditText()
    {
        _infoText.text = 
            $"{Info.Mark} {Info.Model}\n" +
            $"{Info.Description}" +
            $"Максимальная скорость: {Info.MaxSpeed} км/ч" +
            $"Разгон до 100 км/ч: {Info.TimeTo100kmInHour} cек.";
    }
}

[System.Serializable]
public struct CarInaformation
{
    public string Mark;
    public string Model;
    [TextArea(3, 10)] public string Description;
    public float MaxSpeed;
    public float TimeTo100kmInHour;
}