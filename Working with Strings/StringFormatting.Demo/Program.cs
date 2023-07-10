using System.Globalization;

#region Something else about strings

//string message = "Hello World!";

//for (int i = 0; i < message.Length; i++)
//{
//    Console.WriteLine(message[i]);
//}

#endregion

#region Similar to char array
//char[] messageCharactersArray = message.ToCharArray();

//PrintArray(messageCharactersArray);
#endregion

#region Arrays are mutable (can be changed)
// H, e, l, l, o
//messageCharactersArray[1] = '3';

//PrintArray(messageCharactersArray);
#endregion

#region Strings are immutable (can't be changed)
//message[1] = '3';

// Then how this works?
//message = "H3llo World!";

#endregion

#region String Concatenation/Interpolation

//string outputMessage;

//Console.Write("Enter your name: ");
//string userName = Console.ReadLine();
//outputMessage = "Hello " + userName + "!";
//Console.WriteLine(outputMessage);

//Console.Write("Where are you from? ");
//string country = Console.ReadLine();
//outputMessage = string.Concat("Nice to meet you, ", userName, " from ", country, "!");
//Console.WriteLine(outputMessage);

//Console.WriteLine("How are you today? (please be fine)");
//string mood = Console.ReadLine();
//outputMessage = string.Format("I'm glad to hear that you are doing {0}, {1} from {2}!", mood, userName, country);
//Console.WriteLine(outputMessage);
////Console.WriteLine("I'm glad to hear that you are doing {0}, {1} from {2}!", mood, userName, country);

//Console.WriteLine("How is the weather today? (it's better to be sunny)");
//string weather = Console.ReadLine();
//outputMessage = $"Nice to know that it is {weather} in {country} today, {userName}!";
//Console.WriteLine(outputMessage);

#endregion

#region More String Formatting

//string formattedString = string.Format("It is {0:t} at {0:dddd}", DateTime.Now);
//Console.WriteLine(formattedString);

// 1259 - decimal
// 2 - decimal (0 - 9 digits)
// 0010 - binary (0 and 1)
// (0 - 9, A, B, C, D, E, F)


//Console.WriteLine($"This is 3 in hexadecimal: {3:X}");
//double numberToScientificNotation = 115.231;
//Console.WriteLine($"This is {numberToScientificNotation} in binary format: {numberToScientificNotation:E}");

#endregion

#region Culture Info
//CultureInfo polishCultureInfo = new CultureInfo("pl-PL");
//CultureInfo americanCultureInfo = new CultureInfo("en-US");

//const decimal cash = 15.48M;
//Console.WriteLine($"Price in Poland: {cash.ToString("C", polishCultureInfo)}.");
//Console.WriteLine($"Price in USA: {cash.ToString("C", americanCultureInfo)}.");

//CultureInfo.CurrentCulture = polishCultureInfo;
//Console.WriteLine($"Price in Poland: {cash:C}.");
#endregion

#region Utils Methods
static void PrintArray(char[] messageCharactersArray)
{
    for (int i = 0; i < messageCharactersArray.Length; i++)
    {
        Console.Write(messageCharactersArray[i]);
    }
}
#endregion