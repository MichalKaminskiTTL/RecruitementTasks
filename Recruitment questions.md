# General
## C# Basics

What is an interface?

What are the differences between interface and abstract class?

What are the differences between value type and reference types?

How can you create custom reference type and value type?

What does it mean that string is immutable?

What are static classes and how are they initialized in our code?

What are the differences between managed and unmanaged code?

What is an Attribute? How can you create your own Attribute?

What are the differences between const and readonly?

What are the differences between Structures and Class?

What is CLI, CLR, IL?

What is a delegate?

Why can’t you specify access modifiers for items in an interface?

What is an Assembly? What are the different types of Assemblies?

Explain the different parts of an Assembly

What is GAC (Global Assembly Cache?

What is lambda expressions in C#?

What is extension method and how to declare it?

What are the differences between DateTime and DateTimeOffset?

What type to use for currency?

Access modifiers - Public/private/protected

What are the differences betwenn using Virtual/override and new?

What sealed word mean??

What are Ref, out, params?

What is Partial class?

Can structure inherit from other structure?

## Excepion handling

How exception handling works in .net?

What are the differneces between Throw and Throw ex?

What does finally do?

What are Exception filters?

Given exception rethrowing in catch block and finally block to be executed? When the exception will be thrown?

## TPL/Multithreading

What is thread pool?

Difference between asynchronous and multithreading

What is lock?

What is mutex?

## Asynchronous Programming

How async work?

What does async void do?

Task vs Thread

## LINQ

What is LINQ?

Explain deferred execution vs. immediate execution in LINQ

What is Let clause?

## Collections, Enumerators and Iterators

What is the difference between Arrays and Lists?

What is the difference between Hash table and Array list?

How does Dictionary work?

What is IEnumerable?

##GC/Memory Management

How GC works in .net?

What is stack and what is heap?

What is the usage of IDisposable?

What are conditions for a garbage collection?

What are generations?

What is generation 3 or large object heap?

What happens during a garbage collection?

What are differences between system.stringbuilder and system.string?

What is Span and why you should use it over Substring?

What will happen if GC cannot get enough memory?

What is stackalloc?

# Web

## Asp.net Core

What is the ASP.NET Core?

What is a filter?

What is Kestrel?

What is a middleware?

What is MVC?

What is the use of "Map" extension while adding middleware to ASP.NET Core pipeline?

What is routing in ASP.NET Core?

How to specify service lifetime for register service that added as a dependency? (singleton, scoped, transient)

What’s the difference between authentication and authorization?

## Asp.net WebApi

What is REST and what are its key points? (REpresentational State Transfer)

How can you implement a generic action in WebAPI? (you can’t)

Explain State management in ASP .Net.

What is caching?

Cache refresh strategies

Why should we use async/await in api when there is no GUI thread?

HTTP request components (uri, headers, body, method)

Control flow in controller (middleware, filter, routing, controller)?

#Data Access

## ADO.Net

What is ADO.Net?

What are the key features of ADO.Net?

Why is it important to close an ADO.NET application?

What is Connection Pooling?

What is a Dataset?

What is DataAdapter?

What are DataReaders?

## SQL

What are the relation types in db (1-1, 1-n, n-n)? 

How will foreign keys look like?

Query to fetch cars with over 10 parts

What is transaction?

## Entity Framework

What is N+1 anti-pattern? 
https://www.brentozar.com/archive/2018/07/common-entity-framework-problems-n-1/#:~:text=The%20N%20%2B%201%20problem%20is,the%20result%20of%20that%20data.

What is Entity Framework?

Explain what the .edmx file contains.

What is migration?

What is migration history table?

How EF supports transactions?

What are different types of Entity framework approaches? (Database, model, code first)

What is deferred execution?

Explain database concurrency and the way to handle it.

What are different types of loading available to load related entities in EF? (lazy, eager, explicit)

How would you retrieve unique record from db using EF?

Difference between .FirstOrDefault().AsNoTracking() vs .AsNoTracking.FirstOrDefault()

What are the differences between LINQ and EF?
 
# Service Architecture

## General Principles

Do you know what DDD is?

What is dependency injection?

Explain what inheritance is, and why it’s important

Inheritance vs composition

Microservices vs monolith

Do you what CAP theorem is?

What is clean code?

What does polymorphism mean?

## Windows Services

## .net Core Services

What is .NET Core?

How one microservice can talk to another one?

## Cross-service communication (AMQP, ServiceBus, Event Sourcing, etc)

What is CQRS?

What is Event Sourcing?

Have you ever used queues?

What is circuit breaker?

## Authentication and Authorization protocols

What is CAS (Code Access Security)?

# Practices and Tools

## CI/CD Tools

Did you work with CI/CD?

What tools did you use?

## Data Structures

Explain the difference between a stack and a queue.

##OOP Principles

What is SOLID?

Explain some of the SOLID principles

When we can break Liskov principle?

## Design Patterns

What types design patterns do you know and examples? (creational, behavioral, structural)

Difference between Abstract Factory and Factory Method?

Explain one of them (not Singleton)

## Unit testing/TDD

What is TDD?

What are benefits of TDD?

How does Assert work?

If we throw exception before Assert in test what will happen? What will be the test result?

## Algorithms

## Planning and Estimation

#Cloud

## Amazon Cloud

What is default visibility of newly created buckets in S3?

How to limit access to S3 filess for specific users?

What is IAM, roles, policies?

What are RDS and DynamoDB?

