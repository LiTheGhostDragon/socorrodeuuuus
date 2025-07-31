using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class aaaaaa : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI buttonText;
    public Color normalColor = new Color(1f, 1f, 1f);       // branco normal
    public Color glowColor = new Color(1f, 0.85f, 0.2f);     // amarelo claro/brilhante

    void Start()
    {
        if (buttonText == null)
        {
            buttonText = GetComponentInChildren<TextMeshProUGUI>();
        }

        if (buttonText != null)
        {
            buttonText.color = normalColor;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (buttonText != null)
        {
            buttonText.color = glowColor;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (buttonText != null)
        {
            buttonText.color = normalColor;
        }
    }
}