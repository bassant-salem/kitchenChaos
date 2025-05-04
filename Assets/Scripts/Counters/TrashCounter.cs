using UnityEngine;

public class TrashCounter : BaseCounter
{


    public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            player.GetKitchenObject().DestroySelf();
        }
        else
        {
            Debug.Log("Player is trying to trash something, but has nothing to trash");
        }
    }

}
