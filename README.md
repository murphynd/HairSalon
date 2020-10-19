# Eau Claire's Salon

#### _C# ASP.NET MCV Project for Epicodus, Oct 9, 2020_

#### By _**Natalie Murphy**_

## Description

A website where you Can Add Sylists and Clients to a database.

<!-- Brainstorming
- able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist.
-The stylists have specific specialties, so each client can only see (belong to) a single stylist.
_ able to see a list of all stylists.
_ able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
- add new stylists to our system when they are hired.
_ able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.
Naming

 -->

### Specs

| Spec                                          | Input | Output        |
| :-------------------------------------------- | :---- | :------------ |
| 1. Stylist Class, Instantiate a Stylist class | ...   | Stylist Class |
| 2. Add Function, Test and Build               | Test  | Function      |
| 3. Delete Function, Test and Build            | Test  | Function      |
| 4. HTML Home/Index, Create Landing page       | ...   | Homepage      |
| 5. HTML Stylist/Index, Create class pages     | ...   | Class pages   |
| 6. ...                                        | ...   | ...           |

## Setup/Installation Requirements

- Download option

  - Download files from GitHub repository by click Code and Download Zip
  - Extract files into a single directory
  - Run GitBASH in directory
  - Type "dotnet restore" to get bin and obj files
  - Type "dotnet run" in GitBash to run the program
  - Have fun with Places Been! <!-- TITLE HERE -->

- Cloning options
  - For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  - Place files into a single directory
  - Run GitBASH in directory
  - Type "dotnet restore" to get bin and obj files
  - Type "dotnet run" in GitBash to run the program
  - Have fun with Places Been! <!-- TITLE HERE -->

## Database Setup

Go to appsettings.json and change the password if needed.

Setup with SQL migrations

- In the terminal, navigate to the project folder
- Type "dotnet ef migrations add Initial" and wait for migration file to be built
- Type "dotnet ef database update" and wait for build confirmation

Setup with SQL statements

- Enter the following code into your SQL database and run.

```
CREATE DATABASE `Natalie_Murphy` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `Natalie_Murphy`;
CREATE TABLE `Clients`
(
  `ClientID` int
(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar
(450) DEFAULT NULL,
  `Address` varchar
(450) DEFAULT NULL,
  `StylistID` int
(11) DEFAULT '0',
  `City` varchar
(200) DEFAULT NULL,
  `State` varchar
(3) DEFAULT NULL,
  `Email` varchar
(200) DEFAULT NULL,
  PRIMARY KEY
(`ClientID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `Stylists`
(
  `StylistId` int
(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar
(450) DEFAULT NULL,
  `Details` varchar
(450) DEFAULT NULL,
  `Image` varchar
(2000) DEFAULT NULL,
  PRIMARY KEY
(`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

Setup with SQL Import

- MySQL
  - In the Navigator > Administration window, select Data Import/Restore.
  - In Import Options select Import from Self-Contained File.
  - Navigate to Natalie_Murphy.sql.
  - Under Default Schema to be Imported To, select the New button.
    - Enter 'Natalie_Murphy' as the name of your database.
    - Click Ok.
  - Click Start Import.

## Technologies Used

Main Programs

- C# / ASP.NET Core
- MVC
- MySQL

### Other Links

[GitHub](https://github.com/murphynd)

### License

Copyright (c) 2020 **_{Natalie Murphy}_**
Licensed under MIT
