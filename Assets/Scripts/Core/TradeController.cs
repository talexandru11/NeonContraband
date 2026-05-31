using UnityEngine;

public class TradeController : MonoBehaviour
{
    [SerializeField] private PlayerWallet wallet;
    [SerializeField] private Inventory inventory;
    [SerializeField] private HudController hud;
    [SerializeField] private ProductData product;

    public void BuyProduct(ProductData product, int amount = 1)
    {
        if (wallet.SpendCredits(product.buyPrice))
        {
            inventory.AddProduct(product,amount);
            hud.Refresh();
        }
    }

    public void SellProduct(ProductData product, int amount = 1)
    {
        if (inventory.RemoveProduct(product,1))
        {
            wallet.AddCredits(product.sellPrice);
            hud.Refresh(); 
        }
    }

    [ContextMenu("Buy Product")]
    private void DebugBuy()
    {
        BuyProduct(product,1);
    }

    [ContextMenu("Sell Product")]
    private void DebugSell()
    {
        SellProduct(product,1);
    }
}
