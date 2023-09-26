using System.Text.Encodings.Web;

Console.Clear();
// Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

//----------------------------------------------------------------

// void Method2(string msq)
// {
//     Console.WriteLine(msq);
// }
// Method2("Текст сообщения");

// void Method2_1(string msq, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msq);
//         i++;
//     }
// }
// Method2_1("Текст сообщения", 4);
// Method2_1(msq: "Сообщение", count: 4);
// Method2_1(count: 4, msq: "Новое");

//-----------------------------------------------------------------

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//------------------------------------------------------------------

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf" );
// Console.WriteLine(res);

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ " ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие "
+ "прусского короля. Вы так красноречивы. "
+ "Вы дадите мне чаю? ";
Console.WriteLine(text);

string Replace(string text, char oldSym, char newSym)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldSym) result = result + $"{newSym}";
        else result = result + $"{text[i]}";
    }

    return result;

} 

string NewText = Replace(text, ' ', '|');
Console.WriteLine(NewText);

NewText = Replace(text, ' ', '|');
Console.WriteLine(NewText);