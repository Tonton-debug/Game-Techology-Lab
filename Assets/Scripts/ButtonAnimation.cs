using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimation : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler
{
    private Vector3 startScale;

    private void Start()
    {
        startScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = startScale * 1.1f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = startScale;
    }
}
