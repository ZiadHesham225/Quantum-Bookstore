# 📚 Quantum Bookstore Console App

A simple C# console application simulating a bookstore system with support for multiple types of books (PaperBook, EBook, ShowcaseBook).  
The app allows users to buy books and handles delivery via different strategies (shipping or email).  
It also supports inventory management and automatic removal of outdated books.

---

## 🧠 Project Overview

### Features:
- Add various types of books to inventory.
- Purchase books with type-specific behavior.
- Deliver paper books to physical addresses and eBooks to emails.
- Prevent buying showcase-only books.
- Remove outdated books from inventory (based on age).

---
## ✅ Design Principles Used

| Principle | Description |
|----------|-------------|
| **Single Responsibility Principle (SRP)** | Each class has a well-defined responsibility (Book, Inventory, Delivery, etc.). |
| **Open/Closed Principle (OCP)** | You can add new book or delivery types without modifying existing code. |
| **Dependency Inversion Principle (DIP)** | The `Book` class depends on an abstraction `IBookDeliveryStrategy`, not concrete services. |

---

## 🎯 Design Patterns Used

| Pattern | Purpose |
|--------|---------|
| **Strategy Pattern** | To encapsulate different book delivery behaviors (Shipping, Email). |

---


## 🛠 Requirements

- .NET SDK **6.0** or higher  
- A C# IDE like:
  - Visual Studio 2022+
  - Rider
  - Visual Studio Code (with C# extension)

