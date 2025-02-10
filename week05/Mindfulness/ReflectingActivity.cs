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
    private List<string> _questions = new()
    {
        "> What was the most challenging  part of the task ? ",
        "> How did you feel when it was complete ? ",
        "> How did you stay motivated to overcome this obstacle ? ",
        "> What is your favorite thing about this experience ? ",
        "> What was the most challenging  part of the task ? ",
        "> What positive changes or growth emerged from this difficult time?",
        "> What are the key factors that contributed to your struggle?"
    }
    ;
public ReflectionActivity(string name, int duration) : base(name, duration)
{
    _startingMessage = "This activity will help you reflect on times in  your life when you have shown strength and resilience. \nThis will help you recongnize the power you have and how you can use it in other aspect of your life.";
}

public string GetRandomPrompt()
{
    int index = random.Next(_prompts.Count);
   // Console.WriteLine(_prompts[index]);
   string prompt = _prompts[index];
   return prompt;
}
public string GetRandomQuestion()
{
    int index = random.Next(_questions.Count);
    string question = _questions[index];
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