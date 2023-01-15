Console.Clear();

int path = 100;
int minDist = 2;
int speedFrend1 = 1;
int speedFrend2 = 2;
int speedDog = 5;
int choiceFrend = 1; // у какого друга в настоящий момент собака
int count = 0;

while (path > minDist)
{
    if (choiceFrend == 1)
    {
        int timePath = path / (speedDog + speedFrend2);
        path = path - timePath * (speedFrend1 + speedFrend2);
        choiceFrend = 2;
    }
    else
    {
        int timePath = path / (speedDog + speedFrend1);
        path = path - timePath * (speedFrend1 + speedFrend2);
        choiceFrend = 1;
    }
    count += 1;
}
Console.WriteLine($"За время пока 2 друга идут навстречу друг другу, собака пробежит между ними {count} раз.");