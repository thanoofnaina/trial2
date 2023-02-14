Console.Write("Enter Your Name: ");
string realName = Console.ReadLine();
string reverseName = "";

for (int i = realName.Length - 1; i >= 0 ; i--)
{
    reverseName = reverseName + realName[i];
}

Console.WriteLine(reverseName);