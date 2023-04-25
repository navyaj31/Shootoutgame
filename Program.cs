Console.WriteLine("Enter No of robbers: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the robber with whom sam will start shooting: ");
int Start = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the gap between robbers: ");
int gap = Convert.ToInt32(Console.ReadLine());


int[] robbers = new int[n];
int CurrentIndex = Start - 1;
int ShotsCompleted = 0;

for (int i = 0; i < n; i++)
{
    robbers[i] = i + 1;
}


while (n != 0)
{
    if (CurrentIndex >= n)
    {
        CurrentIndex = CurrentIndex % n;
    }


    Console.WriteLine($"Target = {robbers[CurrentIndex]} , {++ShotsCompleted} shots completed");

    for (int i = CurrentIndex; i < n - 1; i++)
    {
        robbers[i] = robbers[i + 1];
    }
    n--;
    CurrentIndex += gap;
}



Console.WriteLine(ShotsCompleted + " shots taken");




