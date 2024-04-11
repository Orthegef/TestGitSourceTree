using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    [SerializeField] private Text testText;
    // Start is called before the first frame update
    void Start()
    {
        testText.text = testText.text + "Test 1\n";
    }
}
