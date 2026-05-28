using UnityEngine;

public class TradeController : MonoBehaviour
{
    [SerializeField] private PlayerWallet wallet;
    [SerializeField] private Inventory inventory;
    [SerializeField] private HudController hud;

    [SerializeField] private int buyPrice = 10;
    [SerializeField] private int sellPrice = 15;

    public void BuyNovaCandy()
    {
        if (wallet.SpendCredits(buyPrice))
        {
            inventory.AddNovaCandy(1);
            hud.Refresh();
        }
    }

    public void SellNovaCandy()
    {
        if (inventory.RemoveNovaCandy(1))
        {
            wallet.AddCredits(sellPrice);
            hud.Refresh();
        }
    }

    [ContextMenu("Buy NovaCandy")]
    private void DebugBuy()
    {
        BuyNovaCandy();
    }

    [ContextMenu("Sell NovaCandy")]
    private void DebugSell()
    {
        SellNovaCandy();
    }
}
