Разбира се, мастър! Ето ти **по-сложни примери за `Func<>` и `Action<>`** с **много подробни обяснения** ред по ред. 
Ще комбинирам различни техники (линк, ламбда, вложени функции, колекции, филтри) за да видиш пълната сила на тези делегати.

---

## ✅ **Сложен пример с `Func<>`: Филтриране и трансформация на колекция**

### 🎯 Цел:

1. Имаме списък от хора (име, възраст).
2. Ще използваме `Func<Person, bool>` за филтриране.
3. Ще използваме `Func<Person, string>` за трансформиране (форматиране).

---

### 🔸 Код:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Иван", Age = 28 },
            new Person { Name = "Мария", Age = 34 },
            new Person { Name = "Петър", Age = 19 },
            new Person { Name = "Елена", Age = 42 }
        };

        // 1. Филтър – само хора над 30 години
        Func<Person, bool> isOlderThan30 = p => p.Age > 30;

        // 2. Трансформация – извеждане на име и възраст в текст
        Func<Person, string> formatPerson = p => $"{p.Name} е на {p.Age} години.";

        // Приложение чрез LINQ
        var result = people
            .Where(isOlderThan30)       // филтрираме
            .Select(formatPerson)       // трансформираме
            .ToList();

        result.ForEach(Console.WriteLine);
    }
}
```

---

### 🔍 Обяснение:

* `Func<Person, bool> isOlderThan30`
  👉 Ламбда израз `p => p.Age > 30`
  👉 Връща `true`, ако възрастта е над 30

* `Func<Person, string> formatPerson`
  👉 Форматира обекта в текст с името и възрастта

* Използваме `Where()` с първия `Func` за филтриране

* Използваме `Select()` с втория `Func` за форматиране

---

## ✅ **Сложен пример с `Action<>`: Манипулация на колекция и странични ефекти**

### 🎯 Цел:

1. Имаме списък от задачи (Task).
2. Ще използваме `Action<Task>` за отпечатване на статус.
3. Ще използваме `Action<List<Task>>` за маркиране на всички като завършени.

---

### 🔸 Код:

```csharp
using System;
using System.Collections.Generic;

class Task
{
    public string Title { get; set; }
    public bool IsDone { get; set; }
}

class Program
{
    static void Main()
    {
        List<Task> tasks = new List<Task>
        {
            new Task { Title = "Измий чиниите", IsDone = false },
            new Task { Title = "Пазарувай", IsDone = false },
            new Task { Title = "Упражнения по C#", IsDone = true }
        };

        // 1. Печат на статус
        Action<Task> printTaskStatus = t =>
        {
            string status = t.IsDone ? "✅ Завършена" : "❌ Незавършена";
            Console.WriteLine($"{t.Title} → {status}");
        };

        // 2. Завършване на всички задачи
        Action<List<Task>> completeAllTasks = taskList =>
        {
            foreach (var task in taskList)
                task.IsDone = true;
        };

        Console.WriteLine("📋 Задачи преди завършване:\n");
        tasks.ForEach(printTaskStatus);

        completeAllTasks(tasks); // Прилагане на Action върху цял списък

        Console.WriteLine("\n📋 Задачи след завършване:\n");
        tasks.ForEach(printTaskStatus);
    }
}
```

---

### 🔍 Обяснение:

* `Action<Task> printTaskStatus`:
  👉 Получава обект `Task`, печата състояние (завършена/незавършена)

* `Action<List<Task>> completeAllTasks`:
  👉 Получава списък от задачи и **променя състоянието им**

* `tasks.ForEach(printTaskStatus)` използва Action за всяка задача

* Страничният ефект: **променяме стойностите вътре в списъка**, а не връщаме нов

---

## 📊 Сравнение в реален контекст:

| Делегат    | Цел               | Типична употреба          | Пример отгоре             |
| ---------- | ----------------- | ------------------------- | ------------------------- |
| `Func<>`   | ВРЪЩА стойност    | филтриране, трансформация | `.Where(isOlderThan30)`   |
| `Action<>` | НЕ връща стойност | странични ефекти, промени | `completeAllTasks(tasks)` |

---

## 🧠 Логическо обобщение:

* **Използвай `Func<>`**, когато искаш да ПРЕВЪРНЕШ нещо в нещо друго.
  *(пример: обект → текст, списък → филтриран списък, числа → сума)*

* **Използвай `Action<>`**, когато искаш ДА НАПРАВИШ нещо.
  *(пример: да промениш стойност, да отпечаташ, да запишеш във файл)*

---



😎 Сега ще ти дам също толкова **детайлно и мощно обяснение за `Predicate<T>`** – с примери, обяснения ред по ред, сравнения с `Func<T,bool>` и практическа употреба.

---

## 🔷 Какво е `Predicate<T>` в C#?

**`Predicate<T>`** е вграден **делегат**, който:

*приема * *само един параметър от тип `T`**
* **винаги връща `bool`**

👉 Това е като `Func<T, bool>`, но с по-ясно семантично значение: **тества дали дадено нещо отговаря на условие**.

---

## ✅ СИНТАКС:

```csharp
Predicate<T> predicateName = t => условие;
```

---

## ✅ Пример 1: Филтриране на числа

```csharp
List<int> numbers = new List<int> { 5, 12, 18, 7, 30 };

// Predicate: дали числото е по-голямо от 10
Predicate<int> isGreaterThan10 = x => x > 10;

// Използваме List.FindAll, която приема Predicate
List<int> filtered = numbers.FindAll(isGreaterThan10);

Console.WriteLine(string.Join(", ", filtered));  // 12, 18, 30
```

---

## 🔍 Подробно обяснение:

* `Predicate<int>` → това е делегат, който приема **int** и връща **bool**
* `isGreaterThan10` съдържа ламбда, която връща `true`, ако `x > 10`
* `FindAll()` от `List<T>` приема **Predicate** и връща нов списък с елементите, за които Predicate връща `true`.

---

## ✅ Пример 2: Проверка дали даден елемент съществува

```csharp
List<string> names = new List<string> { "Иван", "Мария", "Георги" };

Predicate<string> isMaria = name => name == "Мария";

bool found = names.Exists(isMaria);

Console.WriteLine(found);  // True
```

📌 `Exists()` връща `true`, ако има поне един елемент, който отговаря на Predicate.

---

## ✅ Пример 3: Изтриване на елементи, които не отговарят

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

// Изтриваме всички четни числа
Predicate<int> isEven = x => x % 2 == 0;

numbers.RemoveAll(isEven);  // Премахва 2, 4, 6

Console.WriteLine(string.Join(", ", numbers));  // 1, 3, 5
```

---

## ✅ Пример 4: Използване с обекти – пример с хора

```csharp
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

List<Person> people = new List<Person>
{
    new Person { Name = "Иван", Age = 25 },
    new Person { Name = "Мария", Age = 35 },
    new Person { Name = "Гошо", Age = 28 }
};

Predicate<Person> isOlderThan30 = p => p.Age > 30;

Person result = people.Find(isOlderThan30);

Console.WriteLine(result?.Name);  // Мария
```

---

## 🆚 Сравнение: `Predicate<T>` VS `Func<T, bool>`

| Делегат         | Приема | Връща | Използва се в...                      |
| --------------- | -----  | ----- | ------------------------------------- |
| `Predicate < T >| T      | bool  | `List.Find`, `Exists`, `RemoveAll`    |
| `Func<T, bool>` | T      | bool  | LINQ (`Where`, `Any`, `All`, `First`) |

📌 Те правят **едно и също**, но `Predicate<T>` е **по-четим** в контекста на `List<T>` методи.

---

## 🧠 Обобщение:

* ✅ Използвай **`Predicate<T>`**, когато работиш със списъци и искаш да **провериш условие**.
* ✅ Използвай **`Func<T, bool>`**, когато работиш с LINQ, по-гъвкав е.
* ✅ Можеш да предаваш и анонимни ламбди, директно:

```csharp
people.Find(p => p.Name.StartsWith("Г"));
```

---

## 🔥 Истински пример от живота:

### 🎯 Цел: В списък със задачи да намерим първата, която е „важна“ и незавършена.

```csharp
class Task
{
    public string Title { get; set; }
    public bool IsImportant { get; set; }
    public bool IsDone { get; set; }
}

List<Task> tasks = new List<Task>
{
    new Task { Title = "Email до шефа", IsImportant = true, IsDone = false },
    new Task { Title = "Измий колата", IsImportant = false, IsDone = false },
    new Task { Title = "Направи бекъп", IsImportant = true, IsDone = true }
};

Predicate<Task> isUrgentAndNotDone = t => t.IsImportant && !t.IsDone;

Task next = tasks.Find(isUrgentAndNotDone);

Console.WriteLine(next?.Title);  // Email до шефа
```

---
