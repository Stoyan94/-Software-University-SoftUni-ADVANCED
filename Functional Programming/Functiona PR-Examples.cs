ENG VERSION:


---

# 🧪📦 Example: Processing a List of Users (Functional Style in C#)

We have a list of users and we want to:

1.Select only the active users.
2. Calculate their age based on their birth date.
3. Return their names in **uppercase**, **sorted by age**.

---

## 📌 Data

```csharp
public record User(string Name, DateTime BirthDate, bool IsActive);

var users = new List<User>
{
    new("Alice", new DateTime(1990, 5, 12), true),
    new("Bob", new DateTime(1985, 10, 23), false),
    new("Charlie", new DateTime(2000, 2, 5), true),
    new("Diana", new DateTime(1995, 7, 18), true)
};
```

---

## 🧼 Pure Functions

### 1. **Filter active users**

```csharp
Func<IEnumerable<User>, IEnumerable<User>> filterActiveUsers =
    users => users.Where(u => u.IsActive);
```

---

### 2. **Map user to new type with calculated age**

```csharp
public record UserWithAge(string Name, int Age);

Func<User, UserWithAge> mapToUserWithAge = user =>
{
    var today = DateTime.Today;
    var age = today.Year - user.BirthDate.Year;
    if (user.BirthDate.Date > today.AddYears(-age)) age--;
    return new UserWithAge(user.Name, age);
};
```

---

### 3. **Uppercase the user name**

```csharp
Func<UserWithAge, UserWithAge> uppercaseName = u =>
    new UserWithAge(u.Name.ToUpper(), u.Age);
```

---

### 4. **Sort by age**

```csharp
Func<IEnumerable<UserWithAge>, IEnumerable<UserWithAge>> sortByAge =
    users => users.OrderBy(u => u.Age);
```

---

## 🧬 Pipeline – Function Composition

If your compiler supports the pipeline operator `|>`, you can write:

```csharp
var processedUsers = users
    |> filterActiveUsers
    |> (us => us.Select(mapToUserWithAge))
    |> (us => us.Select(uppercaseName))
    |> sortByAge;
```

If `|>` is **not supported**, just chain the function calls like this:

```csharp
var processedUsers = sortByAge(
    users
        .Where(u => u.IsActive)
        .Select(mapToUserWithAge)
        .Select(uppercaseName)
);
```

---

## 🖨️ Output (impure, of course 😄)

```csharp
foreach (var user in processedUsers)
{
    Console.WriteLine($"{user.Name} – {user.Age} years old");
}
```

---

## ✅ What Do We See Here?

| Element | Explanation |
| ------------------------ | ---------------------------------------------- |
| `record` types           | Perfect for immutable data structures          |
| `Func < ...>`            | Functions are objects – first -class citizens  |
| LINQ                     | Enables a clean, transformation-focused style  |
| All processing functions | **Pure** – no side effects                     |
| `Console.WriteLine`      | **Impure** – so we keep it separate from logic |

--





---

BG VERSION:

---

## 🧪📦 Пример: обработка на списък от потребители

Имаме списък от потребители, искаме:

1.Да вземем само активните.
2. Да изчислим възрастта им по дата на раждане.
3. Да върнем имената им в главни букви, сортирани по възраст.

---

## 📌 Данни

```csharp
public record User(string Name, DateTime BirthDate, bool IsActive);
```

```csharp
var users = new List<User>
{
    new("Alice", new DateTime(1990, 5, 12), true),
    new("Bob", new DateTime(1985, 10, 23), false),
    new("Charlie", new DateTime(2000, 2, 5), true),
    new("Diana", new DateTime(1995, 7, 18), true)
};
```

---

## 🧼 Чисти функции

```csharp
// 1. Филтрирай само активните потребители
Func<IEnumerable<User>, IEnumerable<User>> filterActiveUsers =
    users => users.Where(u => u.IsActive);

// 2. Изчисли възрастта и я върни като нов тип
public record UserWithAge(string Name, int Age);

Func<User, UserWithAge> mapToUserWithAge = user =>
{
    var today = DateTime.Today;
    var age = today.Year - user.BirthDate.Year;
    if (user.BirthDate.Date > today.AddYears(-age)) age--;
    return new UserWithAge(user.Name, age);
};

// 3. Преобразувай името в главни букви
Func<UserWithAge, UserWithAge> uppercaseName = u =>
    new UserWithAge(u.Name.ToUpper(), u.Age);

// 4. Сортирай по възраст
Func<IEnumerable<UserWithAge>, IEnumerable<UserWithAge>> sortByAge =
    users => users.OrderBy(u => u.Age);
```

---

## 🧬 Pipeline – свързване на функциите

```csharp
var processedUsers = users
    |> filterActiveUsers        // само активни
    |> (us => us.Select(mapToUserWithAge))   // към UserWithAge
    |> (us => us.Select(uppercaseName))      // Имена в CAPS
    |> sortByAge;              // Сортиране по възраст
```

Ако компилаторът не поддържа оператора `|>` (pipeline operator), можеш просто така:

```csharp
var processedUsers = sortByAge(
    users
        .Where(u => u.IsActive)
        .Select(mapToUserWithAge)
        .Select(uppercaseName)
);
```

---

## 🖨️ Извеждане (импурно, разбира се 😄)

```csharp
foreach (var user in processedUsers)
{
    Console.WriteLine($"{user.Name} – {user.Age} years old");
}
```

---

## ✅ Какво виждаме тук?

| Елемент | Обяснение |
| ------------------- | -------------------------------------- |
| `record` типове     | Идеални за immutable структури.        |
| `Func<...>`         | Функциите са обекти.                   |
| `LINQ`              | Позволява чист трансформационен стил.  |
| Всички функции      | Pure – не променят външното състояние. |
| `Console.WriteLine` | Impure – затова го държим отделно.     |

---