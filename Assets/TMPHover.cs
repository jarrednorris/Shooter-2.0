using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class TMPHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI tmpText;

    private bool isMouseOver;
    private float m_timer;

    public float fadeTime = 1.0f;
    public Color normalColour = Color.white, mouseOverColour = Color.black;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseOver = false;
    }

    private void Update()
    {
        tmpText.color = Color.Lerp(normalColour, mouseOverColour, m_timer / fadeTime);
        m_timer = Mathf.Clamp(m_timer - ((1.0f / fadeTime) * Time.deltaTime) * ((isMouseOver)? -1 : 1), 0, fadeTime);
    }
}