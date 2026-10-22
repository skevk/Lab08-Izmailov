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
    count++;
    
   
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

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Количество неудачных попыток: {failedAttempts}"); 
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
    failedAttempts++; 
}