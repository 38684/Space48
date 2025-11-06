
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipPickup : MonoBehaviour
{
    public List<Color> items = new List<Color>();
    public int activeItemIndex = -1;
    private Image itemImageHolder;

    private void Start()
    {
        itemImageHolder = GameObject.Find("item holder").GetComponent<Image>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            PickUpItem(other.gameObject);
        }
    }
    void PickUpItem(GameObject item)
    {

        Color color = item.gameObject.GetComponent<Renderer>().material.color;

        Destroy(item);

        items.Add(color);

        activeItemIndex = items.Count - 1;

        itemImageHolder.color = items[activeItemIndex];
        itemImageHolder.enabled = true;
    }
}
