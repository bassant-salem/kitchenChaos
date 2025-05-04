using System;
using UnityEngine;

public class StoveCounterVisual : MonoBehaviour
{
    [SerializeField] private StoveCounter stoveCounter;
    [SerializeField] private GameObject stoveOnGameObject;
    [SerializeField] private GameObject particlesGameObject;


    private void Start()
    {
        stoveCounter.OnStateChanged += StoveCounter_OnStateChanged;
        //stoveCounter.OnProgressChanged += StoveCounter_OnProgressChanged;
        //stoveCounter.OnHasKitchenObjectChanged += StoveCounter_OnHasKitchenObjectChanged;
    }

    private void StoveCounter_OnStateChanged(object sender, StoveCounter.OnStateChangedEventArgs e)
    {
        bool showVisuals = e.state == StoveCounter.State.Frying || e.state == StoveCounter.State.Fried;
        stoveOnGameObject.SetActive(showVisuals);
        particlesGameObject.SetActive(showVisuals );

    }
}
