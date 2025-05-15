ENG VERSION:


---

# 🧠 Functional Programming in C\#

Functional Programming (FP) is **not the primary paradigm in C#** (C# is mainly object-oriented), but the language supports enough features to **write code in a functional style**. 
This includes using `Func`, `Action`, lambda expressions, LINQ, immutable structures, and more.

---

## 🧩 Key Concepts in Functional Programming (in the context of C#)

### 1. **Pure Function**

A function that:

*Always returns the **same result** for the same arguments.
* Has **no side effects** (does not modify external state, does not read/write files, change global variables, or print to the console).

📌 **Example of a pure function in C#:**

```csharp
int Add(int x, int y)
{
    return x + y;
}
```

Calling `Add(2, 3)` will always return `5`.
Nothing outside the function is affected.

---

### 2. **Impure Function**

A function that:

*Has * *side effects * * – logging, database access, file I/O, changing global variables, etc.
* Or returns **different results** for the same arguments (e.g., reading the current date/time).

📌 **Example of an impure function:**

```csharp
int AddAndLog(int x, int y)
{
    int result = x + y;
Console.WriteLine($"Result is {result}"); // side effect
return result;
}
```

This has a side effect: output to the console.

---

## 🔄 Functional Programming Concepts and Practices

### 1. **Immutability**

Values **do not change** after they are created.

Instead of modifying an existing object, you create a **new one** with the new state.

📌 Example:

```csharp
var list = new List<int> { 1, 2, 3 };
var newList = list.Select(x => x * 2).ToList();
```

`list` remains unchanged. `newList` is a new object.

-- -

### 2. **First-Class Functions**

Functions are treated like **first-class citizens**.You can:

*Pass them as parameters
* Return them from other functions
* Assign them to variables

📌 Example:

```csharp
Func<int, int, int> add = (x, y) => x + y;
int result = add(2, 3); // 5
```

---

### 3. **Higher-Order Functions**

Functions that:

*Accept other functions as arguments
* Return functions

📌 Example:

```csharp
Func<int, Func<int, int>> adder = x => y => x + y;

var add5 = adder(5); // creates a function that adds 5
int result = add5(3); // 8
```

---

### 4. **Function Composition**

Combining two or more functions so that the **output of one becomes the input of the next**.

📌 Example:

```csharp
Func<int, int> multiplyBy2 = x => x * 2;
Func<int, int> add3 = x => x + 3;

Func<int, int> combined = x => add3(multiplyBy2(x));

int result = combined(4); // (4 * 2) + 3 = 11
```

---

### 5. **Recursion**

Often used instead of loops in functional languages.
In C#, it's possible but not always optimal (due to stack limitations).

📌 Example:

```csharp
int Factorial(int n)
{
    if (n <= 1) return 1;
return n * Factorial(n - 1);
}
```

---

### 6. **LINQ as a Functional Tool**

Operators like `Select`, `Where`, `Aggregate`, `Any`, `All` etc. are **functional in nature**.

📌 Example:

```csharp
var nums = new[] { 1, 2, 3, 4, 5 };
var evenSquares = nums
    .Where(x => x % 2 == 0)
    .Select(x => x * x)
    .ToList();
```

---

## 🧱 Practical Recommendations for FP in C\#

*Avoid side effects in your logic.
* Use `readonly`, `const`, and immutable objects.
* Write small, **pure functions**, each doing one thing.
* **Compose functions** instead of writing long methods.
* Work with `IEnumerable` and LINQ for data transformations.
* Use `record` types for immutable objects (C# 9+):

```csharp
public record Person(string Name, int Age);
```

---




BG VERSION:


Функционалното програмиране(Functional Programming – FP) в C# не е основният парадигмен стил (C# е основно обектно-ориентиран език), но езикът поддържа достатъчно средства, за да се пише код във функционален стил.
Това включва използването на `Func`, `Action`, ламбда изрази, `LINQ`, `immutable` структури, и др.

---

## 🧠 Основни понятия във функционалното програмиране (в контекста на C#):

### 1. **Pure Function (Чиста функция)**

Функция, която:

***Винаги връща еднакъв резултат** за едни и същи аргументи.
* **Няма странични ефекти** (не променя външни състояния, не чете/пише във файл, не променя глобални променливи, не извежда на конзолата).

#### 📌 Пример на **pure function** в C#:

```csharp
int Add(int x, int y)
{
    return x + y;
}
```

* `Add(2, 3)` винаги ще върне `5`.
* Не променя нищо извън себе си.

---

### 2. **Impure Function (Нечиста функция)**

Функция, която:

***Има странични ефекти** – логване, достъп до база данни, писане във файл, промяна на глобални променливи и т.н.
* Или връща различни резултати за едни и същи аргументи (пример – ако чете текуща дата/час).

#### 📌 Пример на **impure function**:

```csharp
int AddAndLog(int x, int y)
{
    int result = x + y;
Console.WriteLine($"Result is {result}"); // страничен ефект
return result;
}
```

*Тук имаме страничен ефект: извеждане в конзолата.

---

## 🔄 Основни концепции и практики във Functional Programming (FP):

### 1. **Immutability (Непроменяемост)**

* Стойностите не се променят след създаване.
* Вместо да променяш съществуващ обект, създаваш нов с нови стойности.

```csharp
var list = new List<int> { 1, 2, 3 };
var newList = list.Select(x => x * 2).ToList();
```

* `list` не се променя. `newList` е нов обект.

---

### 2. **First-class Functions (Функциите са "граждани от първи клас")**

* Можеш да предаваш функции като параметри, да ги връщаш от други функции и да ги присвояваш на променливи.

```csharp
Func<int, int, int> add = (x, y) => x + y;
int result = add(2, 3); // 5
```

---

### 3. **Higher-order Functions (Функции от по-висок ред)**

Функции, които:

* Приемат други функции като параметри.
* Връщат други функции.

```csharp
Func<int, Func<int, int>> adder = x => y => x + y;

var add5 = adder(5); // създава функция, която добавя 5
int result = add5(3); // 8
```

---

### 4. **Function Composition (Композиция на функции)**

Свързване на две или повече функции така, че резултатът от едната е вход към следващата.

```csharp
Func<int, int> multiplyBy2 = x => x * 2;
Func<int, int> add3 = x => x + 3;

Func<int, int> combined = x => add3(multiplyBy2(x));

int result = combined(4); // (4 * 2) + 3 = 11
```

---

### 5. **Recursion (Рекурсия)**

Използва се вместо цикли в много функционални езици. В C# не винаги е оптимално, но е възможно.

```csharp
int Factorial(int n)
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}
```

---

### 6. **LINQ като функционален инструмент**

* `Select`, `Where`, `Aggregate`, `Any`, `All` и др. са функционални по природа.

```csharp
var nums = new[] {1, 2, 3, 4, 5};
var evenSquares = nums
    .Where(x => x % 2 == 0)
    .Select(x => x * x)
    .ToList();
```

---

## 🧱 Практически препоръки за FP в C\#

1. **Избягвай странични ефекти** в логиката.
2. **Използвай `readonly`, `const` и `immutable` обекти.**
3. **Създавай малки, чисти функции**, всяка с една отговорност.
4. **Комбинирай функции**, вместо да пишеш дълги методи.
5. **Работи със `IEnumerable` и LINQ** за трансформации.
6. **Използвай `record` типове за immutable обекти** (в C# 9+).

```csharp
public record Person(string Name, int Age);
```

---