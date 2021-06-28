using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField] private Car[] _cars;
    [SerializeField] private RectTransform _infoPanel;
    [SerializeField] private TMP_Text _infoText;

    //private List<Car> _carsInScene;
    private int _activeCarID = 0;

    public Car ActiveCar { get; private set; }

    private void Start()
    {
        foreach (var car in _cars)
        {
            car.OnCreate(_infoPanel, _infoText);
        }

        ActiveCar = _cars[_activeCarID];
        ActiveCar.Show();
    }

    public void NextCar()
    {
        ActiveCar.Hide();
        if (_activeCarID >= _cars.Length - 1)
            _activeCarID = 0;
        else
            _activeCarID++;
        ActiveCar = _cars[_activeCarID];
        ActiveCar.Show();
    }

    public void PreviusCar()
    {
        ActiveCar.Hide();
        if (_activeCarID <= 0)
            _activeCarID = _cars.Length - 1;
        else
            _activeCarID--;
        ActiveCar = _cars[_activeCarID];
        ActiveCar.Show();
    }
}