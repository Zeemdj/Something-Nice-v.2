using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgifter : MonoBehaviour
{
    #region Game1
    public int UserValue;
    #endregion
    #region Game2
    private int DiceAdd;
    private int DiceSub;
    private int UserPoints = 10;
    #endregion
    #region Game3
    private int Dragon;
    private int Player = 100;
    private int DragonHitChance;
    private int PlayerHit;
    private int DragonHit;
    private int MaxPlayerHit;
    private int MinPlayerHit;
    private int DragonHealthMultiplier;
    private int PlayerCrit;
    private int PlayerLifesteal;
    private bool DragonStart = true;
    #endregion
#region Game5
    private int Number = 50;
    private int RandomNumber;
    private int Score = 0;
    private int HighScore;
    public bool StartBool = true;
    public bool Continue = true;
    //public bool Reset = true;
    #endregion 
    // Use this for initialization
    void Start()
    {

    }

    void Uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            UserValue = UserValue + 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            UserValue = UserValue / 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(UserValue);
        }
    }

    void Uppgift2()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            DiceAdd = Random.Range(1, 7);
            DiceSub = Random.Range(1, 7);
            UserPoints = UserPoints + DiceAdd - DiceSub;
            print("Ditt nuvarande värde är " + UserPoints);
            if (UserPoints >= 20)
            {
                print("Grattis, du Vann!!");
            }
            else if (UserPoints <= 0)
            {
                print("REKT NOOB! Du förlorade");
            }
            else
            {
                print(" kasta igen");
            }
        }
    }

    void Uppgift3()
    {
        if (DragonStart == true)
        {
            Dragon = Random.Range(100, 151);
            MaxPlayerHit = Random.Range(25, 36);
            MinPlayerHit = Random.Range(5, 15);
            DragonHealthMultiplier = Random.Range(0, 10);
            if (DragonHealthMultiplier == 1)
            {
                Dragon = Dragon * 2;
                print("The dragon doubled its health!");
            }
            print("The Dragon have " + Dragon + "this round.");
            DragonStart = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Dragon > 0 && Player > 0)
            {
                DragonHitChance = Random.Range(0, 2);
                PlayerCrit = Random.Range(0, 20);
                DragonHit = Random.Range(10, 26);
                PlayerHit = Random.Range(MinPlayerHit, MaxPlayerHit);
                if (PlayerCrit == 1)
                {
                    PlayerHit = PlayerHit * 100;
                }
                Dragon = Dragon - PlayerHit;
                print("You did " + PlayerHit + " damage to the dragon. The dragon have " + Dragon + " health left");
                if (DragonHitChance == 1)
                {
                    Player = Player - DragonHit;
                    print("The dragon did " + DragonHit + "damage to you. You have " + Player + "health left");
                }

                else
                {
                    print("The dragon missed");
                }

                if (Dragon <= 0)
                {
                    print("You killed the dragon, press R to RESET");
                }

                if (Player <= 0)
                {
                    print("You died, press R to RESET");

                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            DragonStart = true;
            Player = 100;
        }
    }

    void Uppgift5()
    {
        if (StartBool == true)
        {
            print("Let's play Higher or Lower! You start with 50. Press Y to guess higher. Press H to guess lower.");
            StartBool = false;

        }

        if (Continue == true)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                RandomNumber = Random.Range(1, 101);
                if (RandomNumber > Number)
                {
                    Number = RandomNumber;
                    Score = Score + 1;
                    print("You guessed right! Your new number is " + Number + ". Higher or Lower?");

                }
                if (RandomNumber < Number)
                {
                    print("You failed, your score is " + Score);
                    if (Score > HighScore)
                    {
                        HighScore = Score;
                    }
                    print("Highscore: " + HighScore + ". Press R to play again.");
                    Continue = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                RandomNumber = Random.Range(1, 101);
                if (RandomNumber < Number)
                {
                    Number = RandomNumber;
                    Score = Score + 1;
                    print("You guessed right! Your new number is " + Number + ". Higher or Lower?");

                }
                if (RandomNumber > Number)
                {
                    print("You failed, your score is " + Score);
                    if (Score > HighScore)
                    {
                        HighScore = Score;
                    }
                    print("Highscore: " + HighScore + ". Press R to play again.");
                    Continue = false;

                }
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Score = 0;
            Number = 50;
            StartBool = true;
            Continue = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
