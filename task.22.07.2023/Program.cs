#region TASK1
static void CapitalizeSentecne()
{
    string sentence = "bU tasKI metHodla yAzmAlıSız";
    string lowerstr = sentence.ToLower();
    String[] arr = lowerstr.Split(' ');
    string capitalize ="";
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(char.ToUpper(arr[i][0]) + arr[i].Substring(1)+" ");
    }
    //    foreach (var item in arr)
    //    {
    //        capitalize += item[0].ToString().ToUpper() + item.Substring(1) + " ";
    //    }
    //Console.WriteLine(capitalize);
}
CapitalizeSentecne();


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
//int AdditionNumber = 3;
#endregion

