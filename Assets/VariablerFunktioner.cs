using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablerFunktioner : MonoBehaviour
{
    public string sentence1;
    public string sentence2;
    public string sentence3;

    public int X;

    public int triangleBase;

    public float TårtbitIGrader;
    public float Tårtbit;

    public string Username;
    public string[] prefixes;
    public string[] suffixes;

    public float radius;

    public int damage;
    public int DemonLife = 890000;
    public int AntalDemoner;
    public int MinDamage;
    public int MaxDamage;

    private int count = 2;

    // Use this for initialization
    void Start()
    {
       
    }



    void uppgift1()
    {
        Debug.Log("uppgift 1: " + (963 * 421 - 175463 / 87f));
    }

    void uppgift2()
    {
        Debug.Log(string.Format("uppgift 2: " + "{0} {1} {2}", sentence1, sentence2, sentence3));
    }

    void uppgift3()
    {
        Debug.Log("Användarens input (X) i kvardrat " + Mathf.Pow(X, 2));
        Debug.Log("Roten ur anvädrarens input (X) " + Mathf.Sqrt(X));
    }

    void uppgift4()
    {
        Debug.Log("Arean av triangeln är " + ((8 * triangleBase) / 2) + " m^2");
    }

    void uppgift5()
    {
        Debug.Log("Du kommer få " + (360f / TårtbitIGrader) + " bitar");
    }

    void uppgift5a()
    {
        Debug.Log("Dina biter kommer vara " + (360f/Tårtbit) + "grader stora");
    }

    void uppgift6()
    { 
        Debug.Log(string.Format("{0} {1} {2}", prefixes[Random.Range(0, 5)], Username, suffixes[Random.Range(0, 5)]));
    }

    void uppgift7()
    {
        Debug.Log("Volymen på klotet är " + (4f * 3.14f * Mathf.Pow((radius), 3f) / 3f));
    }

    void uppgift8()
    {
        Debug.Log("Det tar " + ((DemonLife * AntalDemoner) / damage) + "slag innan demonen är besegrad");
    }

    void uppgift8c()
    {
        Debug.Log("Du behöver minst " + (DemonLife * AntalDemoner / MaxDamage) + " slag," +
            " max " + (DemonLife * AntalDemoner / MinDamage) + " slag" +
            " och i snitt " + (DemonLife * AntalDemoner / ((MinDamage + MaxDamage) / 2)) + "slag");

    }

    void uppgift9()
    {
        Debug.Log(count = count * 2);
    }

    void uppgift10()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
