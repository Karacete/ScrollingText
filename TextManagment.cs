using System.Collections;
using TMPro;
using UnityEngine;

public class TextManagment : MonoBehaviour
{
    [SerializeField] [TextArea] private string[] text;
    [SerializeField] private float textSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI textMesh;
    private int currentDisplayingText = 0;
    public void ActivateText()
    {
        StartCoroutine(AnimateText());
    }
    IEnumerator AnimateText()
    {
        for (int i = 0; i < text[currentDisplayingText].Length + 1; i++)
        {
            textMesh.text = text[currentDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
