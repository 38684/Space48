
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipChangeItem : MonoBehaviour
{
    [SerializeField] List<Color> items;
    [SerializeField] ShipPickup shipPickup;
    private Image itemImageHolder;

    private void Start()
    {
        itemImageHolder = GameObject.Find("item holder").GetComponent<Image>();
    }

    void Update()
    {
        CycleItems();
    }

    void CycleItems()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (items.Count > 0)
            {
                if (shipPickup.activeItemIndex < items.Count - 1)
                {
                    shipPickup.activeItemIndex++;
                }
                else
                {
                    shipPickup.activeItemIndex = 0;
                }
                itemImageHolder.color = items[shipPickup.activeItemIndex];
            }
            else
            {
                itemImageHolder.color = Color.white;
                shipPickup.activeItemIndex = -1;
                itemImageHolder.enabled = false;
            }
        }
    }
}
