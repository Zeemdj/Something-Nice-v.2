using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{

    // Public = syns i unity
    // Int = Heltal
    // Hejsan = namnet
    public int hejsan;

    // float = decimaltal med 7 precision
    public float george;

    // double = decimaltal med 15 precision
    public double bush;

    // string = text
    public string minecraft;

    // Bool = Något som är True/false
    public bool john;

    /* "Multi-line comment"
     * Lååååååå
     * ååååång
     * komentar
     */

    // char = Ett tecken
    public char dennis;

    // Use this for initialization
    void Start()
    {
        //PrintText();
        Calculate();
    }

    void PrintText()
    {
        Debug.Log(minecraft);
        Debug.Log(hejsan + george);
        Calculate();
        //Debug.LogError(
        //    Mathf.Sqrt(3617) +
        //    Mathf.Sqrt(3617));
    }

    void Calculate()
    {
        Debug.Log(5 + 5);
        Debug.Log(9 / 2f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
