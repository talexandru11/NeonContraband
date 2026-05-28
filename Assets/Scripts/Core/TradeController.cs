using UnityEngine;

public class TradeController : MonoBehaviour
{
    [SerializeField] private PlayerWallet wallet;
    [SerializeField] private Inventory inventory;
    [SerializeField] private HudController hud;
    [SerializeField] private ProductData product;

    public void BuyProduct()
    {
        if (wallet.SpendCredits(product.buyPrice))
        {
            inventory.AddNovaCandy(1);
            hud.Refresh();
        }
    }

    public void SellProduct()
    {
        if (inventory.RemoveNovaCandy(1))
        {
            wallet.AddCredits(product.sellPrice);
            hud.Refresh();
        }
    }

    [ContextMenu("Buy Product")]
    private void DebugBuy()
    {
        BuyProduct();
    }

    [ContextMenu("Sell Product")]
    private void DebugSell()
    {
        SellProduct();
    }
}
