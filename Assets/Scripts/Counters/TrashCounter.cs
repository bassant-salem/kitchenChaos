using System;
using UnityEngine;

public class TrashCounter : BaseCounter
{

    public static event EventHandler OnAnyObjectTrashed;
    public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            player.GetKitchenObject().DestroySelf();
            OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            Debug.Log("Player is trying to trash something, but has nothing to trash");
        }
    }

}
