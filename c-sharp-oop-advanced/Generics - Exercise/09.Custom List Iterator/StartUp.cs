using System;

public class StartUp
{
    public static void Main()
    {
        var customList = new GenericDataStructure<string>();

        CommandInterpreter.RunCommands(customList);
    }
}
