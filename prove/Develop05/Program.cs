using System;
using System.IO;
using System.Runtime.CompilerServices;

// stretch:
// 1. Set and save user name
// 2. Give user different levels of titles depending on their points
// 3. Handle the wrong user inputs
// 4. check if the file for saving already exist or not

// To do:
// You did it!!
class Program
{   
    private static int _totalPoints = 0;   
    private static string _userlevel;
    private static List<string> levels = new List<string> {"Rookie", "Adventurer", "Warrior", "Champion", "Legend"};
    private static string _userName = "__Create Your UserName__";
    private static bool _isFinished = false;
    private static int _response;
    private static List<Goal> _goalInfo = new List<Goal>();
    // use @"" to create a long string
    private static string _goalMenu = 
@"The types of Goals are:  
1. Simple Goal (Goal with only one achieving count.)
2. Eternal Goal (Goal with unlimited achieving counts.)
3. Checklist Goal (Goal with achieving it for multiple times, receiving bonus points as you finish it.)

Which type of goal do you want to create? ";
    private static string menu = 
@" Choose an action:
0. Create your user name (Please create your username if you haven't)
1. Create New Goal
2. List Goals (Display all your goals) 
3. Save Goals (Save goals into a file for future use. Load goals from a file BEFORE you save them.)
4. Load Goals (Please load Goals FIRST if you already have a previous record)
5. Record Goals (Record your progress for finished goal)
6. Quit
    
Select a choice from the menu: ";

    public static int GetValidInt()
        {   
            int outputPoint = -1;
            bool set = false;
            while (!set)
            {
                if (int.TryParse(Console.ReadLine(), out int point) && point > 0) // make sure user sets the points to a positive interger
                {
                    outputPoint = point;
                    set = true;
                }
                else
                {
                    Console.WriteLine("Please insert valid interger number in the range and make sure it's bigger than zero");
                }
            }
            return outputPoint;
        }

    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to goal progressing challenge! ");
        while (!_isFinished)
        {   
            if (_totalPoints < 100)
            {
               _userlevel = levels[0];
            }

            else if (_totalPoints >= 100 && _totalPoints < 200)
            {
                _userlevel = levels[1];
            }
            
            else if (_totalPoints >= 200 && _totalPoints < 300)
            {
                _userlevel = levels[2];
            }

            else if (_totalPoints >= 300 && _totalPoints < 400)
            {
                _userlevel = levels[3];
            }

            else
            {
                _userlevel = levels[4];
            }
            Console.WriteLine(new string('-', 50));
            Console.Write("Please press enter to display goal menu. >> ");
            string keep = Console.ReadLine();
            
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"{_userName}, You have {_totalPoints} points.");
            Console.WriteLine($"Current level: '{_userlevel}'\n");
            Console.Write(menu);
            
            if (int.TryParse(Console.ReadLine(), out int number) && number >=0 && number <=6)
            {
                _response = number;
                if(_response == 0)
                {   
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Please enter your user name: ");
                    _userName = Console.ReadLine();
                }

                else if (_response == 1)
                {
                    // V create new goal
                    // Save it to the top of the program as a variable
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine($"\n{_goalMenu}");
                    
                    string goalType = Console.ReadLine();
                    bool isGoalSet = false;
                    while (!isGoalSet)
                    {
                        if (goalType == "1")
                        {
                            SimpleGoal simplegoal = new SimpleGoal("SimpleGoal");
                            _goalInfo.Add(simplegoal);
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("Goal successfully created");
                            break;
                        }
                        else if (goalType == "2")
                        {
                            EternalGoal eternalGoal = new EternalGoal("EternalGoal");
                            _goalInfo.Add(eternalGoal);
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("Goal successfully created");
                            break;
                        }
                        else if (goalType == "3")
                        {   
                            ChecklistGoal checklistGoal = new ChecklistGoal("ChecklistGoal");
                            _goalInfo.Add(checklistGoal);
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("Goal successfully created");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid choice");
                        }
                    }
                }

                else if (_response == 2)
                {
                    // V list goals
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("The goals are: ");
                    for (int i = 0; i < _goalInfo.Count; i++)
                    {   
                        Console.Write($"{i+1}. ");
                        Console.WriteLine(_goalInfo[i].DisplayGoalList());
                        // index: i
                        // value: _goalInfo[i]
                    }
                }

                else if (_response == 3)
                {
                    // V save goals
                    Console.WriteLine(new string('-', 50));
                    Console.Write("If you provide an existing filename, it will save the goals to the existing file. \nIf not, it will create a new file for your goals.\nEnter the filename: (Ex. Coolkid.txt) >>");

                    string fileName = Console.ReadLine();
                    if (File.Exists(fileName))
                    {
                        // overwrite the first item first
                        // if the file already exist, get the _goalinfo first then overwrite it
                        using (StreamWriter outputFile = new StreamWriter(fileName))
                        {   
                            outputFile.Write(string.Empty);
                            outputFile.WriteLine(_totalPoints); // [0] is the total points
                            outputFile.WriteLine(_userName);
                            for (int i = 0; i < _goalInfo.Count; i++)
                            {   
                                outputFile.WriteLine(_goalInfo[i].AppendGoalToList());
                                // index: i
                                // value: _goalInfo[i]
                            }
                            // Console.WriteLine("Goals Saved path 1");
                        }
                    }

                    else
                    {
                        using (StreamWriter outputFile = new StreamWriter(fileName))
                        {   
                            outputFile.WriteLine(_totalPoints); // [0] is the total points
                            outputFile.WriteLine(_userName);
                            for (int i = 0; i < _goalInfo.Count; i++)
                            {   
                                outputFile.WriteLine(_goalInfo[i].AppendGoalToList());
                                // index: i
                                // value: _goalInfo[i]
                            }
                            // Console.WriteLine("Goals Saved Path 2");
                        }
                    }
                }

                else if (_response == 4)
                {
                    // V load goals
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("What is the name of the file you want to load the goals from? (Without the file type): ");

                    bool fileVaild = false;
                    string fileName = Console.ReadLine();

                    while (!fileVaild) //If the file does not exist, it will keep asking for the file name
                    {
                        if (File.Exists(fileName))
                        {
                            string[] lines = File.ReadAllLines(fileName);
                            _totalPoints = int.Parse(lines[0]); 
                            _userName = lines[1];
                                
                            for (int i = 2; i < lines.Length; i++)
                            {
                                string type = lines[i].Split(",")[0].Split(":")[0]; // get the goal type 
                                // Ex. (SimpleGoal:test1, desc1, 50, False) splits by "," then get the first part
                                // -> (SimpleGoal:test1) splits by ":" then get the first part, which is the goal type -> SimpleGoal
                                if (type == "SimpleGoal")
                                {   
                                
                                    //Thoughs: using 2 different simplegoal class constructors. One for creating a new goal, and one for loading the goal from the file. 
                                    // 1. SimpleGoal() -> create goal
                                    // 2. SimpleGoal(string goalName, string goalExplanation, int addPoints) -> load goal from file
                                    SimpleGoal simplegoal1 = new SimpleGoal();
                                    simplegoal1.LoadFileGoalInfo(lines[i].Split(",")); // load the goal info from the file
                                    _goalInfo.Add(simplegoal1);
                                }
                                else if (type == "EternalGoal")
                                {   
                                    EternalGoal eternalgoal = new EternalGoal();
                                    eternalgoal.LoadFileGoalInfo(lines[i].Split(",")); // load the goal info from the file
                                    _goalInfo.Add(eternalgoal);
                                    // invoke EternalGoal class
                                }
                                else if (type == "ChecklistGoal")
                                {   
                                    ChecklistGoal checklistgoal = new ChecklistGoal();
                                    checklistgoal.LoadFileGoalInfo(lines[i].Split(",")); // load the goal info from the file
                                    _goalInfo.Add(checklistgoal);
                                    // invoke ChecklistGoal class
                                }

                            }
                            fileVaild = true;
                            Console.WriteLine("Loaded successfully.");
                        }
                        
                        else
                        {
                            Console.WriteLine("Please provide the valid file name.");
                        }
                    }
                    // create different loadgoals functions for simple, eternal, and checklist goals. Using the first item (goal type) to identify which function to call.
                }

                else if (_response == 5)
                {
                    // record goals
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("The goals are: ");
                
                    for (int i = 0; i < _goalInfo.Count; i++) // Display the goal names 
                    {   
                        Console.Write($"{i+1}. ");
                        Console.WriteLine(_goalInfo[i].GetGoalName());
                    }
                    Console.Write("Which goal did you accomplish? "); // Get the achieved goal index
                    int goalIndex = GetValidInt();

                    Console.WriteLine(new string('-', 50)); 
                    _totalPoints = _goalInfo[goalIndex - 1].RecordGoalProcess(_totalPoints); // Do the points validation test & update the points
                    Console.WriteLine($"You now have {_totalPoints} points.");

                }

                else if (_response == 6)
                {
                    // quit
                    Console.WriteLine($"Keep grinding on your journey of goals, {_userName}, See ya!");
                    Thread.Sleep(3000);
                    _isFinished = true;
                }
            }

            else
            {
                Console.WriteLine("Please enter a valid choice");
            }

        //1. Create New Goal
        //2. List Goals
        //3. Save Goals -> Write _goalInfor list to a file. Examine if the file name exist, if so, create a copy file(ex. copy of {filename}); if not, create the normal file.
        //4. Load Goals -> Read _goalInfor list from a file
        //5. Record Goals -> Update _goalInfor list with new goal information
            // simple goal: get the points ([2]), set the done boolean to True ([3])
            // eternal goal: get the points ([2])
            // checklist goal: get the points ([2]), finished times++([6])
        //6. Quit

        }


    }

    
}

