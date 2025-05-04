using System;
using UnityEngine;


// To avoid the confilict between the the order of Awake methods one run before the other (unity decide what to run first)
// (Awake run before the start)
// we use awake for initialization of the script and start for any external refrance 
public class SelectedCounterVisual : MonoBehaviour
{
    // listen to the event from Player
    [SerializeField] private BaseCounter baseCounter; 
    [SerializeField] private GameObject[] visualGameObjectArray; 
    private void Start()
    {
      Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
        
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == baseCounter)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }
    private void Show()
    {
        foreach(GameObject visualGameObject in visualGameObjectArray)
        {
            visualGameObject.SetActive(true);

        }
    }
    private void Hide()
    {
        foreach (GameObject visualGameObject in visualGameObjectArray)
        {
            visualGameObject.SetActive(false);
        } 
    }
}
