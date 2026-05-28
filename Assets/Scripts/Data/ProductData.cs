using UnityEngine;

    [CreateAssetMenu(menuName = "NeonContraband/Product")]
    public class ProductData: ScriptableObject

    {
        public string productName;
        public int buyPrice;
        public int sellPrice;
    }
