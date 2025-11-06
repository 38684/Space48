
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ShipItemUse : MonoBehaviour
{
    [SerializeField] ShipPickup shipPickup;
    [SerializeField] ShipMovement shipMovement;
    private Image itemImageHolder;

    private Text displayText;

    private void Start()
    {
        displayText = GameObject.Find("DisplayText").GetComponent<Text>();
        itemImageHolder = GameObject.Find("item holder").GetComponent<Image>();
    }

    private void Update()
    {
        UseItem();
    }

    void UseItem()
    {

        if (Input.GetKeyDown(KeyCode.E) && shipPickup.items.Count > 0 && shipPickup.activeItemIndex != -1)
        {

            if (shipPickup.items[shipPickup.activeItemIndex] == Color.blue)
            {
                StartCoroutine(displayText.ShowMessage(" +  Move Speed", 3f));
                shipMovement.moveSpeed += 5;
            }
            else if (shipPickup.items[shipPickup.activeItemIndex] == Color.red)
            {
                StartCoroutine(displayText.ShowMessage(" + Fire Rate", 3f));
                shipMovement.cooldownTime -= 0.1f;
            }
            else if (shipPickup.items[shipPickup.activeItemIndex] == Color.green)
            {
                StartCoroutine(displayText.ShowMessage(" + Rotation Speed", 3f));
                shipMovement.rotationSpeed += 10;
            }
            shipPickup.items.RemoveAt(shipPickup.activeItemIndex);
            if (shipPickup.activeItemIndex > 0)
            {
                shipPickup.activeItemIndex--;
                itemImageHolder.color = shipPickup.items[shipPickup.activeItemIndex];
            }
            else if (shipPickup.items.Count == 0)
            {
                itemImageHolder.color = Color.white;
                shipPickup.activeItemIndex = -1;
                itemImageHolder.enabled = false;
            }
        }
    }
}
