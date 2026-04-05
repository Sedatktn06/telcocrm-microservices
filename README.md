# TelcoCrm Microservices

A comprehensive e-commerce / CRM backend system built using **Microservices Architecture** and **.NET 9**, following **Onion Architecture** and clean code principles.

---

## 🧱 Architecture Overview

This project is designed with a modular and scalable architecture:

* **Microservices-based design**
* **Onion Architecture** for each service
* **Domain-Driven Design (DDD) principles**
* **Separation of concerns across layers**
* Shared **building blocks** for reusable components

---

## 📂 Project Structure

```
TelcoCrm-Microservice
 ┣ services
 ┃ ┗ customer-service
 ┃   ┣ Application
 ┃   ┣ Domain
 ┃   ┣ Infrastructure
 ┃   ┣ Persistence
 ┃   ┗ WebApi
 ┣ building-blocks
 ┃ ┗ core
 ┃   ┗ CoreDomain
 ┣ packages
```

---

## ⚙️ Technologies

* **.NET 9**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **Onion Architecture**
* **Microservices Architecture**
* **NuGet (Local Package Management)**

---

## 🧩 Core (Building Blocks)

The `Core` project is designed as a reusable package and includes:

* Base entity classes
* Common response models
* Shared abstractions
* Exception handling infrastructure

This project is distributed as a **local NuGet package** and consumed by services.

---

## 👤 Customer Service

The `CustomerService` microservice includes:

* Customer domain management
* Address and related entities
* Layered architecture:

  * Domain
  * Application
  * Infrastructure
  * Persistence
  * API

---

## 🔄 Development Approach

* Each service is developed independently
* Shared logic is extracted into `building-blocks`
* Services communicate through well-defined contracts (future scope)
* Clean and maintainable code structure

---

## 🚀 Future Improvements

* API Gateway integration
* Authentication & Authorization (JWT / IdentityServer)
* Messaging (RabbitMQ / Kafka)
* Docker & containerization
* CI/CD pipeline

---

## 📌 Purpose

This project is developed to demonstrate:

* Real-world microservices architecture
* Clean architecture implementation
* Scalable backend system design
* Professional .NET backend development practices

---

## 👨‍💻 Author

**Sedat Kotan**

---
