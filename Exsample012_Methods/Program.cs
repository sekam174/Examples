// таблица умножения (вывод на экран)

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//               РАБОТА С ТЕКСТОМ
// дан текст. в тексте нужно все пробелы 
// заменить чёрточками, маленькие буквы "к"
// заменить большими "К", а большие "C"
// заменить маленькими "c"

string text = "- Я думаю, сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"            
//            012345
//s[] //r

String Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i=0; i<length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);