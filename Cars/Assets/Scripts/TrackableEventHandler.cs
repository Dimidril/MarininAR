using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackableEventHandler : DefaultTrackableEventHandler
{
    [SerializeField] private RectTransform _startPanel;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        _startPanel.gameObject.SetActive(false);
    }
}