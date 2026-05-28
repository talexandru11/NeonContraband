using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private int credits = 100;
    [SerializeField] private int ghostChips = 100;
    public int Credits => credits;
    public int GhostChips => ghostChips;

    public bool CanAffordCredits(int amount)
    {
        return credits >= amount;
    }

    public bool SpendCredits(int amount)
    {
        if (!CanAffordCredits(amount))
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
    public bool CanAffordGhostChips(int amount)
    {
        return ghostChips >= amount;
    }
    public bool SpendGhostChips(int amount)
    {
        if (!CanAffordGhostChips(amount))
    {
        return false;
    }
    credits -= amount;
        return true;
    }
    public void AddGhostChips(int amount)
    {
        ghostChips += amount;
    }
}

