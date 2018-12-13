using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntVarToText : MonoBehaviour
{
    public TMPro.TextMeshProUGUI tmpText;

    public string prefix, suffix;
    public IntVariable intVar;

    private void LateUpdate()
    {
        tmpText.text = prefix + intVar.RuntimeValue + suffix;
    }
}
