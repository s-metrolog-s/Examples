int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time;
int count = 0;

Console.WriteLine("Введите растояние между друзьями:");
double distance = Convert.ToDouble(Console.ReadLine());

while (distance > 10)
{
    if (friend == 1)
    {
        time = (distance/(firstFriendSpeed + dogSpeed));
        friend = 2;
    }
    else
    {
        time = (distance/(secondFriendSpeed + dogSpeed));
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.Write("Собака пробежит: ");
Console.Write(count);
Console.Write(" раз");