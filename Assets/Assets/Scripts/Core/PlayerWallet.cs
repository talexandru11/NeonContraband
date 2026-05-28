using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private int credits = 100;
    public int Credits => credits;

    public bool CanAfford(int amount)
    {
        return credits >= amount;
    }

    public bool SpendCredits(int amount)
    {
        if (!CanAfford(amount))
        {
            return false;
        }
        credits -= amount;
        return true;
    }

    public void AddCredits(int amount)
    {
        credits += amount;
    }
}

