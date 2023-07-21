using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TEXT_GAME_MNGR : MonoBehaviour
{
    public int staminaValue;
    public TextMeshProUGUI staminaTextValue, startTextValue;
    public string startOfStory;
    public GameObject Lvl1_Choices, main_menu, Lvl2_2ndpathChoices, Lvl2_3rdpathChoices, Lvl3_2ndpathChoices, Lvl3_3rdpathChoices, done;

    // Start is called before the first frame update
    void Start()
    {
        staminaValue = 50;
        startOfStory = "In front of you, you saw 3 paths. There's also a door behind you, but it is locked. The first path looks dark. The second path has a torch at the end of it. The last path leads to 3 levels up. But be careful, you don't know what's ahead.";
    }

    // Update is called once per frame
    void Update()
    {
        staminaTextValue.text = staminaValue.ToString();
        startTextValue.text = startOfStory;
    }

    public void StartAdv()
    {
        main_menu.SetActive(false);
        Lvl1_Choices.SetActive(true);
    }

    public void FirstPath()
    {
        staminaValue = 0;
        startOfStory = "A lion attacked you. YOU DIED.";
    }

    public void SecondPath()
    {
        staminaValue -= 10; //lost 10 instead of 5
        startOfStory = "You picked up the torch, but you lost 10 stamina. You saw 2 more paths. The first one is a bright path, and you can see the people dancing in circles and singing. The second path leads to a tunnel that has a shining thing at the end of it.";
        Lvl1_Choices.SetActive(false);
        Lvl2_2ndpathChoices.SetActive(true);
    }

    public void SecondPath1stBut()
    {
        staminaValue = 0;
        startOfStory = "Those are cannibals. YOU DIED.";
    }

    public void SecondPath2ndBut()
    {
        staminaValue -= 5;
        startOfStory = "You struggled going in, but you made it! The shining object is a key on the door where you started. Now you have the choice to go back and open the door, or continue going in the narrow path.";
        Lvl2_2ndpathChoices.SetActive(false);
        Lvl3_2ndpathChoices.SetActive(true);
    }

    public void SecondPathP21stBut()
    {
        staminaValue = 0;
        startOfStory = "You chose to go back and open the door. The door opened a mechanism that causes the whole maze to close. You died.";
    }

    public void SecondPathP22ndBut()
    {
        staminaValue -= 5;
        startOfStory = "You took the narrow part. You struggled and lost 20 stamina. At the end of the path, you saw a treasure chest and picked it up. Ahead, you can see 2 paths. You only have to choose the right one to escape the maze. Both paths are lighted and has a door at the end.";
        Lvl3_2ndpathChoices.SetActive(true);
        Lvl3_3rdpathChoices.SetActive(false);
    }

    public void ThirdPath()
    {
        staminaValue -= 5; //user lost 5 and gained 10. 
        startOfStory = "You only have 2 more paths to cross to escape the maze. You picked up and ate the apple you saw on the ground. You earned 10 stamina. You saw 2 more paths along the way. Both paths doesn't really have a difference except for the narrowed part.";
        Lvl1_Choices.SetActive(false);
        Lvl2_2ndpathChoices.SetActive(false);
        Lvl2_3rdpathChoices.SetActive(true);
    }

    public void ThirdPath1stBut()
    {
        staminaValue -= 20;
        startOfStory = "You took the narrow part. You struggled and lost 20 stamina. At the end of the path, you saw a treasure chest and picked it up. Ahead, you can see 2 paths. You only have to choose the right one to escape the maze. Both paths are lighted and has a door at the end.";
        Lvl2_2ndpathChoices.SetActive(false);
        Lvl3_3rdpathChoices.SetActive(true);
    }

    public void ThirdPath2ndBut()
    {
        staminaValue = 0;
        startOfStory = "It's a trap! You encountered a section of the maze where the floor is disguised or absent, leading to a bottomless pit. You stepped on the pit along the way and died.";
    }

    public void ThirdPath1st1But()
    {
        staminaValue -= 5;
        startOfStory = "Congratulations! You successfully escaped the maze.";
        done.SetActive(true);
    }

    public void ThirdPath1st2But()
    {
        staminaValue = 0;
        startOfStory = "It's a trap. You stepped onto a section of the floor rigged with concealed spikes. You died";
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
