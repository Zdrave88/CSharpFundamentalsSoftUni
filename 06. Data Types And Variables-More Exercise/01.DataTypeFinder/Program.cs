while (true)
{
    var input = Console.ReadLine();
    {
        string dataType = "";
        if (input == "END")
        {
            break;
        }
        else if (int.TryParse(input, out int intValue))
        { 
            dataType = "integer";
            Console.WriteLine($"{input} is {dataType} type");
        }
        else if (float.TryParse(input, out float floatValue))
        {
            dataType = "floating point";
            Console.WriteLine($"{input} is {dataType} type");
        }
        else if (char.TryParse(input, out char chartValue))
        {
            dataType = "character";
            Console.WriteLine($"{input} is {dataType} type");
        }
        else if (bool.TryParse(input, out bool boolValue))
        {
            dataType = "boolean";
            Console.WriteLine($"{input} is {dataType} type");
        }
        else
        {
            dataType = "string";
            Console.WriteLine($"{input} is {dataType} type");
        }
    }
}