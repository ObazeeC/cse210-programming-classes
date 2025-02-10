using System;
public class ReflectionActivity : Activity
{
    public Random random = new();
    private List<string> _prompts = new()
    {
        "*** Think of a time when you did something really difficult.***",
        "*** Think of time in your life when you faced a significant obstacle.***",
        "*** Think of a personal habit or mindset that has helped achieve difficult things.***",
        "*** Think of someone you admire for thier strength and resilience.***",
        "*** Reflect on period of struggle or hardship in your life.***",
        "*** Describe a moment in your life that marked a significant turning point.***",
        "*** Think of seemingly small or everyday challenge that you face regularly. ***",
    };
    private List<string> _prompt02;
    private List<string> _questions = new()
    {
        "> What was the most challenging  part of the task ? ",
        "> How did you feel when it was complete ? ",
        "> How did you stay motivated to overcome this obstacle ? ",
        "> What is your favorite thing about this experience ? ",
        "> What inspiration did received from it ? ",
        "> What positive changes or growth emerged from this difficult time?",
        "> What are the key factors that contributed to your struggle?"
    }
    ;
        private List<string> _question02;
public ReflectionActivity(string name, int duration) : base(name, duration)
{
    _startingMessage = "This activity will help you reflect on times in  your life when you have shown strength and resilience. This will help you recongnize the power you have and how you can use it in other aspect of your life.";
    _prompt02 = new(_prompts);  
    _question02 = new(_questions); 
}

public string GetRandomPrompt()
{
    if(_prompt02.Count == 0)
    {
        _prompt02 = new(_prompts); // Reinitialize the list when it is empty
    }   
    int index = random.Next(_prompt02.Count);
    string prompt = _prompts[index];
    _prompt02.RemoveAt(index); // Remove the select prompt from the list
                
    return prompt;
}
public string GetRandomQuestion()
{
    if(_question02.Count == 0)
    {
        _question02 = new(_questions); // Reinitialize the list when it is empty.(suppose to course it to start again from the begining once all items in the list are exhausted)
    }
    int index = random.Next(_question02.Count);
    string question = _question02[index]; 
    _question02.RemoveAt(index);   // Remove the selected question
    return question;
}
public void DisplayQuestion()
{
    Console.Write(GetRandomQuestion());
}
public void DisplayPrompt()
{
    Console.WriteLine(GetRandomPrompt());
}
public void Run()
{
    DisplayQuestion();
    ShowSpinner(10);
    Thread.Sleep(1000);
    Console.WriteLine();
}
}