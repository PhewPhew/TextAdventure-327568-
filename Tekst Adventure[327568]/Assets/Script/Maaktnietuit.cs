using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Maaktnietuit : MonoBehaviour
{

    private enum States
    {
        start,
        intro1,
        mushroom,
        mushroom_dead,
        mushroom_eat,
        river,
        river_dead,
        ignore_thirst,
        cabin_ignore,
        cabin_go,
        drink,
        take_it,
        ask,
        kill
    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void OnUserInput(string input)
    { 
        switch (currentState)
        {
            case States.start:
            if (input == "start")
            {
                Terminal.ClearScreen();
                currentState = States.intro1;
                StartIntro();
            }

            else if (input == "1337")
            {
                Terminal.WriteLine("Jij bent Leet!");
            }

            else
            {
                Terminal.WriteLine("Error");
            }

            break;
            case States.intro1:
                if (input == "continue")
                {
                    Terminal.ClearScreen();
                    currentState = States.mushroom;
                    MushroomScene();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }

                break;
            case States.mushroom:
                if (input == "eat it")
                {
                    Terminal.ClearScreen();
                    currentState = States.mushroom_eat;
                    MushroomEat();
                }
                
                else if (input == "dont eat it")
                {
                    Terminal.ClearScreen();
                    currentState = States.mushroom_dead;
                    MushroomDead();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.mushroom_dead:
                if (input == "restart")
                {
                    Terminal.ClearScreen();
                    currentState = States.intro1;
                    StartIntro();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.mushroom_eat:
                if (input == "look for a river")
                {
                    Terminal.ClearScreen();
                    currentState = States.river;
                    RiverScene();
                }
                
                else if (input == "ignore your thirst")
                {
                    Terminal.ClearScreen();
                    currentState = States.ignore_thirst;
                    IgnoreThirst();
                }
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.river:
                if (input == "climb down")
                {
                    Terminal.ClearScreen();
                    currentState = States.river_dead;
                    RiverDead();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.river_dead:
                if (input == "restart")
                {
                    Terminal.ClearScreen();
                    currentState = States.intro1;
                    StartIntro();
                }
                break;
            case States.ignore_thirst:
                if (input == "ignore the cabin")
                {
                    Terminal.ClearScreen();
                    currentState = States.cabin_ignore;
                    CabinIgnore();
                }
                
                else if (input == "go in the cabin")
                {
                    Terminal.ClearScreen();
                    currentState = States.cabin_go;
                    CabinGo();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.cabin_ignore:
                if (input == "restart")
                {
                    Terminal.ClearScreen();
                    currentState = States.intro1;
                    StartIntro();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.cabin_go:
                if (input == "drink the bottle of liquid")
                {
                    Terminal.ClearScreen();
                    currentState = States.drink;
                    DrinkDead();
                }
                
                else if (input == "take it with you")
                {
                    Terminal.ClearScreen();
                    currentState = States.take_it;
                    TakeIt();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.drink:
                if (input == "restart")
                {
                    Terminal.ClearScreen();
                    currentState = States.intro1;
                    StartIntro();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.take_it:
                if (input == "ask for help")
                {
                    Terminal.ClearScreen();
                    currentState = States.ask;
                    AskHelp();
                }
                
                else if (input == "try to kill him")
                {
                    Terminal.ClearScreen();
                    currentState = States.kill;
                    KillHim();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.kill:
                if (input == "restart")
                {
                    Terminal.ClearScreen();
                    currentState = States.intro1;
                    StartIntro();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
            case States.ask:
                if (input == "restart")
                {
                    Terminal.ClearScreen();
                    currentState = States.intro1;
                    StartIntro();
                }
                
                else
                {
                    Terminal.WriteLine("Error");
                }
                break;
        }
    }


    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("         Welcome to Forest");
        Terminal.WriteLine("");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("    Type start to begin");
    }
    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("It is a dark night and you're in a");
        Terminal.WriteLine("forest alone. You're lost and your");
        Terminal.WriteLine("goal is to find a way out but there");
        Terminal.WriteLine("are wild wolves around.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">continue");
    }

    void MushroomScene()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("You're tired, hungry and lost. However");
        Terminal.WriteLine("you walk past looking this interesting");
        Terminal.WriteLine("looking mushroom.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">eat it");
        Terminal.WriteLine(">dont eat it");
    }

    void MushroomDead()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("You've been walking for days and you");
        Terminal.WriteLine("died of starvation. Later on, a wolf");
        Terminal.WriteLine("found your body and ate it.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">restart");
    }

    void MushroomEat()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("After eating the mushroom, you can't");
        Terminal.WriteLine("smell anything for the rest of the day.");
        Terminal.WriteLine("You are getting thirsty.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">ignore your thirst");
        Terminal.WriteLine(">look for a river");
    }

    void RiverScene()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("You found a river, but the wolves ");
        Terminal.WriteLine("were close by and attacked you. ");
        Terminal.WriteLine("Luckily, you managed to climb up a");
        Terminal.WriteLine("tree and waited until they gave up.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">climb down");
    }

    void RiverDead()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("Unfortunately, you fell down and broke");
        Terminal.WriteLine("your neck.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">restart");
    }

    void IgnoreThirst()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("You've been walking around for a day");
        Terminal.WriteLine("now and you're getting slower.");
        Terminal.WriteLine("Luckily, you managed to climb up a");
        Terminal.WriteLine("tree and waited until they gave up.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">ignore the cabin");
        Terminal.WriteLine(">go in the cabin");
    }

    void CabinIgnore()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("You're in the middle of nowhere and");
        Terminal.WriteLine("the wolves found you. You tried to  ");
        Terminal.WriteLine("fight back but they outnumbered you");
        Terminal.WriteLine("and you're dead.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">restart");
    }

    void CabinGo()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("You're look around the cabin and find");
        Terminal.WriteLine("a bottle of liquid, which is glowing.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">drink the bottle of liquid");
        Terminal.WriteLine(">take it with you");
    }

    void DrinkDead()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("You feel fine for the first 2 hours,");
        Terminal.WriteLine("but you choked to death afterwards.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">restart");
    }

    void TakeIt()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("You hear someone approaching the");
        Terminal.WriteLine("cabin.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">ask for help");
        Terminal.WriteLine(">try to kill him");
    }

    void KillHim()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("He actually a Ninja, who has lived in");
        Terminal.WriteLine("the forest for years. He tried to");
        Terminal.WriteLine("immobilize you but accidentally");
        Terminal.WriteLine("killed you.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine(">restart");
    }

    void AskHelp()
    {
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("It was a Ninja, who has lived in the");
        Terminal.WriteLine("forest for years. He gladly helped");
        Terminal.WriteLine("you out of the forest.");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("");
        Terminal.WriteLine("Congratulations you've finished the");
        Terminal.WriteLine("game! If you want to play again type");
        Terminal.WriteLine(">restart");
    }
}
