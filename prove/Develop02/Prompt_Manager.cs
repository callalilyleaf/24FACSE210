using System;

public class PromptManager
{
    public List<string> _prompts = new List<string>
    {"What made me smile today?",
    "How did I show kindness to myself or others?",
    "What challenge did I face, and how did I approach it?",
    "What am I grateful for in this moment?",
    "How did I step out of my comfort zone today?",
    "What did I learn about myself?",
    "How did I prioritize my wellbeing?",
    "What small victory am I proud of?",
    "How did I contribute to my long-term goals?",
    "What positive change did I notice in my surroundings?",
    "How did I turn a negative situation into a positive one?",
    "What inspired me today?",
    "How did I use my time meaningfully?",
    "What boundary did I set or maintain?",
    "How did I nurture an important relationship?",
    "What unexpected event today taught me something new?",
    "How did I practice self-compassion in a difficult moment?",
    "What habit am I trying to build, and how did I work on it today?",
    "Which of my personal values did I honor through my actions?",
    "What's a question I'm currently grappling with in my life?",
    "How did I connect with nature or my environment today?",
    "What's a fear I faced or a risk I took, no matter how small?",
    "How did I express my creativity or curiosity?",
    "What's something I read, heard, or saw that changed my perspective?",
    "How did I take care of my future self today?"
    };

    public PromptManager()
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random(); // Create a Random object
        return _prompts[random.Next(0, _prompts.Count)];
    }



}