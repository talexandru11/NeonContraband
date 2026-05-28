using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private int novaCandyAmount = 0;

    public int NovaCandyAmount => novaCandyAmount;

    public void AddNovaCandy(int amount)
    {
        novaCandyAmount += amount;
    }
    
    public bool RemoveNovaCandy(int amount)
    {
        if(novaCandyAmount <= 0)
        {
            return false;
        }

        novaCandyAmount -= amount;
        return true;
    }
}
