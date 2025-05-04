using UnityEngine;

public class BaseCounter : MonoBehaviour , IKitchenObjectParent
{
    
    [SerializeField] private Transform CounterTopPoint;


    private KitchenObject kitchenObject;
    public virtual void Interact(Player player)
    {
        // This method is meant to be overridden in derived classes
        Debug.LogError("Interact method not implemented in " + gameObject.name);
    }
    public virtual void InteractAlternate(Player player)
    {
        // This method is meant to be overridden in derived classes
       // Debug.LogError("InteractAlternate method not implemented in " + gameObject.name);
    }
    public Transform GetKitchenObjectFollowTransform()
    {
        return CounterTopPoint;
    }
    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }
    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }
    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }
    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
