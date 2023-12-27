using System.Text;

//while (true)
//{
//    try
//    {
//        Console.WriteLine("=======================");
//        Console.Write("Input a number: ");

//        int input = int.Parse(Console.ReadLine());

//        if (input < 18)
//            throw new UserIsTooYoungException();

//        Console.WriteLine($"Your number is: {input}");

//        double div = 100 / input;

//        Console.WriteLine($"100 divided by {input} is {div}");
//    }
//    catch (Exception ex)
//    {
//        Console.Clear();

//        Console.WriteLine(ex.Message);

//        continue;
//    }
//}

while (true)
{
    string path = @"D:\file.txt";
    FileStream? всмысле = null;

    try
    {
        Console.WriteLine("=================================");
        Console.WriteLine("What should we write to file.txt?");
        
        string text = Console.ReadLine() ?? string.Empty;

        всмысле = new FileStream(path, FileMode.Append, FileAccess.Write);

        всмысле.Write(Encoding.UTF8.GetBytes(text + "\n"));

        Console.WriteLine($"'{text}' was added to file.txt");
    }
    catch (IOException ex)
    {

    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex.Message);
        continue;
    }
    finally
    {
        //всмысле!?.Close();
    }
}