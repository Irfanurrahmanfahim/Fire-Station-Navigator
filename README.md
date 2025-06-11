# Fire Station Navigator (C#)

**Fire Station Navigator** is a C#-based desktop application designed to help users **locate fire stations across the UK** and **add new ones** to a centralized database. It provides functionality to **mark new fire station locations** and **find the closest fire station** to any given location using geographic coordinates.

## 🔍 Key Features

* **Add New Fire Stations**: Input fire station name, address, and coordinates to store in the database.
* **Find Nearest Station**: Enter any location in the UK and retrieve the closest fire station using geospatial queries.
* **Map Integration** : Visualize locations on a map for better context.

## 🗂 Technologies Used

* **C#** – for the main application logic and UI
* **MongoDB** – to store and query fire station data (geospatial indexing used)
* **MongoDB.Driver** – official MongoDB C# driver
* *(Optional: Windows Forms / WPF / .NET Core depending on your UI)*

## ⚠️ Note

> 🚫 **This project currently requires a MongoDB connection to function fully.**
> As the original MongoDB account has been discontinued, users must **connect a new MongoDB instance** to use the application completely.
> Missing Mondodb package files. Install the package again.



## 📚 Learning Objectives

* Understand C# integration with NoSQL databases
* Learn how to perform **geospatial queries** using MongoDB
* Build practical, map-based tools for emergency services or location management
