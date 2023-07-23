#region TASK1
//static void CapitalizeSentecne()
//{
//    string sentence = "bU tasKI metHodla yAzmAlıSız";
//    string lowerstr = sentence.ToLower();
//    String[] arr = lowerstr.Split(' ');
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.WriteLine(char.ToUpper(arr[i][0]) + arr[i].Substring(1));
//    }
//}
//CapitalizeSentecne();


#endregion

#region TASK2
//Console.WriteLine("Enter number:");
//string numberStr = Console.ReadLine();
//int number;
//bool result = int.TryParse(numberStr, out number);
//if (!result)
//{
//    Console.WriteLine("Please enter valid number");
//    return;
//}
//int AdditionNum = 3;
Console.WriteLine("Enter number:");
string Number = Console.ReadLine();
string[] arr = Number.Split(' ');
string AdditionNumber = "3";
for (int i = 0; i < arr.Length; i++)
{
    arr[0] = AdditionNumber;
    arr[i] = arr[i] + 1;

    Console.WriteLine(arr[i]);
}




#endregion

