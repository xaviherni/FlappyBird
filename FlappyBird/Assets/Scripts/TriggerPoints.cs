using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerPoints : MonoBehaviour
{
    public static float points;

    [SerializeField] private TextMeshProUGUI textMeshPro;

    private void Start()
    {
        textMeshPro.text = points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        points++;
        textMeshPro.text = points.ToString();
    }


}
