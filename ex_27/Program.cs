//Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.


Console.WriteLine("введите число");
double r = Convert.ToDouble(Console.ReadLine());
string s = Convert.ToString(r);
int sum = 0;

for (int i = 0; i < s.Length; i++)
{
    if (char.IsNumber(s[i]))
    {

        sum += Convert.ToInt32(s[i].ToString());
    }
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
