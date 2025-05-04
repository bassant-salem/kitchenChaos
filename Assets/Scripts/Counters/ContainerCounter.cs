using System;
using UnityEngine;

public class ContainerCounter : BaseCounter 
{
    // when the player interacts with the counter, it will spawn a kitchen object and set it as the parent

    public event EventHandler OnPlayerGrabbedObject;


    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    


   
    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject())
        {
            // player is not carrying anything

            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);  
          

            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
        

    }

 
}
