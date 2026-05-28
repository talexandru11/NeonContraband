using UnityEngine;
using TMPro;

public class HudController : MonoBehaviour
{
    [SerializeField] private PlayerWallet wallet;
    [SerializeField] private Inventory inventory;
    [SerializeField] private TextMeshProUGUI creditsText;
    [SerializeField] private TextMeshProUGUI inventoryText;

    private void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        creditsText.text = "Credits: " + wallet.Credits;
        inventoryText.text = "NovaCandy: " + inventory.NovaCandyAmount;
    }

}
