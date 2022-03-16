# _To Do List_

#### By _**Jessi Baker, Ryan Bass & Andy Plymate**_

#### _Message Board - Epicodus - C# and .NET - Many-To-Many Relationships_

## Technologies Used

* GIT
* CS
* ASP.NET MVC
* MYSQL
* Entity Framework
* LINQ

## Description

This is a website.

## Setup/Installation Requirements

* Go to _https://github.com/jessb-epicodus/MessageBoard.git_
* Cone this repository to your desktop (or other desired location)
* Navigate to the top level of the project directory called _MessageBoard_
* Enter the following in your terminal to add required packages:
  * _dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0_
  * _dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2_
  * _dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0_
* To access the database, a _MYSQL_ login & password is required.
* Still in the project directory, add a file, _appsettings.json_.  Add the following code to that file & fill in your password as designated
  _{_
    _"ConnectionStrings": {_
        _"DefaultConnection": "Server=localhost;Port=3306;database=message_board;uid=root;pwd=YOUR-PASSWORD-HERE;"_
    _}_
  _}_
* Protect your password by adding _*/appsettings.json_ to your .gitignore
* Open the index.html file in your browser
* _This is not yet published._

## Known Bugs

* No known issues

## License

Copyright (c) _Mar 2022_ _Jessi Baker | Ryan Bass | Andy Plymate_

## Contact

_If you run into any issues or have questions, ideas or concerns or wish to make a contribution to the code see contact information below._
* Jessi Baker <jessb.epicodus@gmail.com>
* Ryan Bass <>
* Andy Plymate <>