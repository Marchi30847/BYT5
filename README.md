# 🏗️ Design Patterns Implementation

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET%208.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-Completed-success?style=for-the-badge)

A practical implementation of key software design patterns in **C#**. This project demonstrates architectural solutions within a business context (Analytics, Billing, and Notification systems).

---

## 🎯 Implemented Patterns

### 1. 🏭 Factory Method
**Goal:** Unify and standardize the way the analytics service interacts with different database systems.
* **Solution:** Implemented the `DatabaseFactory` class.
* **Result:** The client code (`DataAnalyticsEngine`) interacts with the `IDatabase` abstraction and remains independent of specific implementations (SQL Server or Oracle).

### 2. 🔌 Adapter Pattern
**Goal:** Integrate a legacy HR system (which outputs string arrays) with a third-party billing system (which requires a list of objects).
* **Solution:** Created the `EmployeeAdapter` class implementing the `ITarget` interface.
* **Result:** The adapter converts `string[,]` into `List<Employee>` on the fly, bridging the gap between incompatible interfaces without modifying the existing systems.

### 3. 👀 Observer Pattern
**Goal:** Implement a notification system to alert customers when out-of-stock products become available.
* **Solution:** Implemented a subscription mechanism using `ISubject` and `IObserver`.
* **Result:** When the product status changes in the `Subject` class, all registered subscribers (`ConcreteObserver`) are automatically notified via the `Update()` method.

---
