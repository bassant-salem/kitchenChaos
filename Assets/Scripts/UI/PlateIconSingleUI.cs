
using UnityEngine;
using UnityEngine.UI;

public class PlateIconSingleUI : MonoBehaviour
{
    [SerializeField] private Image image;
    public void SetKitchenObjectSO(KitchenObjectSO kitchenObjectSO) =>
        // Set the icon image to the sprite of the kitchen object
        // Set the icon to active
        // Set the icon to inactive if kitchenObjectSO is null
        image.sprite = kitchenObjectSO.sprite;
}
