int lessonNumber = 5; 
int totalLessons = 5;

while (lessonNumber >= 1) { 
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--; 
}

Console.WriteLine("Пары закончились");


Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

int count = 0;

while (grade != -1) {
    Console.WriteLine($"Оценка принята: {grade}");
    count++; 
    
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Ввод завершён. Всего введено оценок: {count}");


int sum = 0;
int count2 = 0;
int maxGrade = int.MinValue;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade2 = int.Parse(Console.ReadLine());

while (grade2 != -1) {
    sum += grade2;
    count2++;
    
   
    if (grade2 > maxGrade) {
        maxGrade = grade2; 
    }
    
    grade2 = int.Parse(Console.ReadLine());
}

if (count2 > 0) {
    Console.WriteLine($"Средний балл: {(double)sum / count}");
    Console.WriteLine($"Наибольшая оценка: {maxGrade}"); 
} else {
    Console.WriteLine("Оценок не было введено");
}


string correctPassword = "qwerty123";
int failedAttempts = 0;

while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Количество неудачных попыток: {failedAttempts}");
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
    failedAttempts++;
}


string answer;

do {
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.Write("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранён");


int count3 = 0; 
string name;

Console.WriteLine("Вводите имена учеников (для завершения введите 'конец'):");


name = Console.ReadLine();


while (name != "конец") {
    count3++; 
    
    
    name = Console.ReadLine(); 
}

Console.WriteLine($"Ввод завершен. Всего введено имен: {count3}");


int totalPages = 0; 
int pagesPerDay;

Console.WriteLine("Вводите количество прочитанных страниц за день (для завершения введите -1):");


pagesPerDay = int.Parse(Console.ReadLine());


while (pagesPerDay != -1) {
    totalPages += pagesPerDay; 
    
    
    pagesPerDay = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Ввод завершен. Всего прочитано страниц: {totalPages}");


Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname)) {
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


int sum2 = 0; 
int number;

Console.WriteLine("Вводите целые числа (для завершения введите 0):");


number = int.Parse(Console.ReadLine());

while (number != 0)
{
    if (number > 0)
    {
        sum2 += number;
    }

    number = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Ввод завершен. Сумма положительных чисел: {sum2}");


double sum3 = 0; 


for (int day = 1; day <= 7; day++) {
    Console.Write($"Введите температуру за {day}-й день: ");
    double temp = double.Parse(Console.ReadLine());
    
    sum3 += temp; 
}


double average = sum3 / 7;

Console.WriteLine($"Средняя температура за неделю: {Math.Round(average, 1)}");