using System;

public class GoalMenu
{

    private string _menu = $@"
Goal Menu Options
___________________________________________
The Types of Goals are:
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
4. Bad Habit Goal
5. Back to Main Menu
____________________________________________
What type of goal would you like to create?  ";

    public string _goalInput;
    private int _goalChoice = 0;


    public int GoalChoice()

    {

        Console.Write(_menu);

        _goalInput = Console.ReadLine();
        _goalChoice = 0;
       
        try
        {
            _goalChoice = int.Parse(_goalInput);
        }
        catch (FormatException)
        {
            _goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _goalChoice;
    }



}