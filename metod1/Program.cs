

Console.WriteLine("==================================");
Console.WriteLine("--- Анкета нового пользователя ---");
Console.WriteLine("==================================");
Console.WriteLine("Введите вашу имя: ");
string name = Console.ReadLine();

Console.WriteLine("Введите вашу фамилию: ");
string surname = Console.ReadLine();

Console.WriteLine("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());

CalculateBirthYear(age, name);

void CalculateBirthYear(int age , string surname)
{
    int birthYear = DateTime.Now.Year - age;
    Console.WriteLine($"Фамилия : {surname} , примерный год рождения : {birthYear}");
}

CalculateBirthYear( age, surname);

Console.WriteLine("===================================");
Console.WriteLine("--- Профиль пользователя создан ---");
Console.WriteLine("===================================");
Console.WriteLine($"Имя : {name}");
Console.WriteLine($"Фамилия : {surname}");
Console.WriteLine($"Возраст : {age}");
Console.WriteLine("===================================");