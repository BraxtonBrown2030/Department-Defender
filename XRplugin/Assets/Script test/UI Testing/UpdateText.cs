using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateText : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public FloatData data;
    
    public void Update()
    {
        text.text = data.value.ToString();
    }
    
}
