# 📚 Repository Overview

This repository contains several C# projects demonstrating various programming concepts. Implemented as part of the Windows programming labs.

## 📅 Task Scheduler App

### Description
A console app to schedule and execute one-time and recurring tasks.

### Features
- **One-time task**: Schedule a single execution.
- **Recurring task**: Schedule periodic executions.
- **Delete tasks**: Remove tasks.
- **Display tasks**: View all tasks.
- **Task details**: View specific task details.
- **Manual trigger**: Execute a task manually.

### Instructions
1. **Compile**: `dotnet build`
2. **Run**: Execute the compiled file.
3. **Menu**: Use the keyboard to navigate.

---

## 📝 String Library

### Description
Extension methods for the `string` class to count various occurrences in strings.

### Usage
1. **Install**: Include `StringLibrary.cs` in your project.
2. **Import**: `using StringLibrary;`
3. **Call methods**: Use methods like `CountOccurrences(char c)`.

### Example
```csharp
using StringLibrary;

class Program
{
    static void Main(string[] args)
    {
        string text = "Lorem ipsum dolor sit amet.";
        Console.WriteLine($"Occurrences of 'i': {text.CountOccurrences('i')}");
    }
}
```
# 📚 Library Management System

## Description
Manage a library database of books and magazines.

## Features
- **Add Book**: Add new books.
- **Add Magazine**: Add new magazines.
- **Display Database**: Show all items.
- **Save/Load Database**: Save to or load from a text file.

## Instructions
1. **Run**: Execute the main program.
2. **Choose an option**: Follow on-screen instructions.

---

# 🌳 AVL Tree and Singleton Pattern

## DrzewoAVL (AVL Tree)

### Description
Efficiently balanced binary tree for fast data operations.

## Singleton Pattern

### Description
Ensure a single instance of a class exists.
