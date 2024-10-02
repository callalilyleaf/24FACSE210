class Costume
{
    //attributes (member variables)
    public string headWear;

    public string gloves;

    public string shoes;
    
    public string upperGarments;
    
    public string lowerGarments;
    
    public string accessory;


    //behaviors
    public void showWardrobe()
    {
        string result = "";
        result += $"Head: {headWear}\n";
        result += $"Head: {gloves}\n";
        result += $"Head: {shoes}\n";
        result += $"Head: {upperGarments}\n";
        result += $"Head: {lowerGarments}\n";
        result += $"Head: {accessory}\n";

        Console.WriteLine(result);
    }

}