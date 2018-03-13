using System.Text;

public class Spy : Soldier, ISpy
{
    private int codeNumber;

    public Spy(string id, string firstName, string lastName, int codeNumber)
        : base(id, firstName, lastName)
    {
        this.codeNumber = codeNumber;
    }

    public int CodeNumber => this.codeNumber;

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder
            .AppendLine(base.ToString())
            .AppendLine($"Code Number: {this.CodeNumber}");

        return builder.ToString().Trim();
    }
}