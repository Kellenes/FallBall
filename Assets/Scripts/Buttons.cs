using UnityEngine;
using UnityEngine.Events;

public class Buttons : MonoBehaviour
{
    [SerializeField] private UnityEvent AfterClick;


    private void OnMouseDown() {
        Invoke(nameof(AfterClick), 0);
    }
}
