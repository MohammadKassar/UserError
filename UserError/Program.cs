public class Program
{
    public static void Main(string[] args)
    {
        NumericInputError numericError = new NumericInputError();
        Console.WriteLine(numericError.UEMessage());

        TextInputError textError = new TextInputError();
        Console.WriteLine(textError.UEMessage());

        CustomError1 customError1 = new CustomError1();
        Console.WriteLine(customError1.UEMessage());

        CustomError2 customError2 = new CustomError2();
        Console.WriteLine(customError2.UEMessage());

        CustomError3 customError3 = new CustomError3();
        Console.WriteLine(customError3.UEMessage());
    }
}

public abstract class UserError
{
    public abstract string UEMessage();
}
public class NumericInputError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use numeric input in a text only field. This fired an error!";
    }
}
public class TextInputError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use a text input in a numeric only field. This fired an error!";
    }
}
public class CustomError1 : UserError
{
    public override string UEMessage()
    {
        return " First Custom Error ";
    }
}
public class CustomError2 : UserError
{
    public override string UEMessage()
    {
        return " Sec Custom Error ";
    }
}
public class CustomError3 : UserError
{
    public override string UEMessage()
    {
        return " Third Custom Error ";
    }
}
