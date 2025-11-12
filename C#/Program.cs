string TrimText(string text)
{
    if (string.IsNullOrEmpty(text))
    {
        return string.Empty;
    }
    return text.Trim();
}

string ToUpperCase(string text)
{
    if (string.IsNullOrEmpty(text)) 
    {
        return string.Empty;
    }
    return text.ToUpper();
}

string Censor(string text)
{
    if (string.IsNullOrEmpty(text))
    {
        return string.Empty;
    }
    List<string> censoredWords = new List<string> { "job", "salary", "work", "interview", "school", "teacher", "lecture", "course", "class", "instructor", "principal", "homework", "lab", "exam", "test", "quiz", "project", "university"};
    foreach (string word in censoredWords) 
    {
        text = text.Replace(word, "****", StringComparison.OrdinalIgnoreCase);
    }
    return text;
}

string Prefix(string text, string prefix)
{
    if (string.IsNullOrEmpty(prefix))
    {
        return text;
    }
    else if (string.IsNullOrEmpty(text))
    {
        return string.Empty;
    }

    return prefix + text;
}

string ProcessText(string text, List<Func<string, string>> operations)
{
    foreach (Func<string, string> operation in operations)
    {
        text = operation(text);
    }

    string localString = "ProcessText function is my safe haven!";
    
    string LocalFunction(string localString) 
    {
        return localString;
    }

    Console.WriteLine(LocalFunction(localString));

    return text;
}

List<Func<string, string>> operations = new List<Func<string, string>>() { TrimText, ToUpperCase, Censor, text => Prefix(text, "Filtered: ") };
// operations.ForEach(operation => Console.WriteLine(operation("Hello, world from job interview")));
Console.WriteLine(ProcessText("Hello to job interview", new List<Func<string, string>>() { TrimText, ToUpperCase, Censor, text => Prefix(text, "Filtered: ") }));

// You see? Below is an error. It's because localString variable is only accessed inside of ProcessText function.
// Console.WriteLine(localString);

Func<string, string> CreateCensor(List<string> wordsToCensor)
{
    return text =>
    {
        if (string.IsNullOrEmpty(text))
        {
            return string.Empty;
        }

        foreach (string word in wordsToCensor)
        {
            text = text.Replace(word, "****", StringComparison.OrdinalIgnoreCase);
        }

        return text;
    };
}

var censor = CreateCensor(new List<string> { "job", "salary", "work", "interview", "school", "teacher", "lecture", "course", "class", "instructor", "principal", "homework", "lab", "exam", "test", "quiz", "project", "university" });

string result = censor("Hello, world from job interview");
// Console.WriteLine(result);

Func<string, string> CreatePrefixer(string prefix)
{
    return text =>
    {
        if (string.IsNullOrEmpty(prefix))
        {
            return text;
        } 
        else if (string.IsNullOrEmpty(text))
        {
            return string.Empty;
        }

        return prefix + text;
    };
}

var prefixer = CreatePrefixer("Filtered: ");

string result2 = prefixer("Hello, world from job interview");
// Console.WriteLine(result2);
