using TMPro;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _errorsText;
    private Perceptron _perceptron;

    private void Awake()
    {
        _perceptron = GetComponent<Perceptron>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BCube>())
            _errorsText.text = _perceptron.ErrorsNumber.ToString() + " попытки/ок";
    }
}
