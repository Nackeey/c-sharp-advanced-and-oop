using System;

public class StartUp
{
    public static void Main()
    {
        GenericDataStructure<string> list = new GenericDataStructure<string>();

        CommandInterpreter.RunCommands(list);
    }
}
