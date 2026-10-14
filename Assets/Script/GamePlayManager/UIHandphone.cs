using UnityEngine;
using UnityEngine.EventSystems;

public class UIButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private MoveSet carController;
    [SerializeField] private float inputValue; // Isi 1 untuk Maju, -1 untuk Mundur

    // Dipanggil saat tombol MULAI DITEKAN/DITAHAN
    public void OnPointerDown(PointerEventData eventData)
    {
        carController.SetMoveInput(inputValue);
    }

    // Dipanggil saat tombol DILEPAS
    public void OnPointerUp(PointerEventData eventData)
    {
        carController.SetMoveInput(0f);
    }
}