# Pierre's Treats

#### _Inventory many to many C# app, 3/27/2020_

#### By _**Jack Dunning**_

## Description

_App to track inventory of treats and the treats respective flavors for a shop owner._

## Setup/Installation Requirements

* _Download .NET from here: https://dotnet.microsoft.com/download/dotnet-core/current_
* _Download .NET script in the Terminal with this command { dotnet tool install -g dotnet-script }_
* _Download MySQL from here: https://dev.mysql.com/downloads/_
  * _In MySQL_
    * CREATE DATABASE pierres;
    * USE pierres;
    * CREATE TABLE treats (TreatId serial PRIMARY KEY, TreatName LONGTEXT, FlavorId INT);
    * CREATE TABLE treatflavors (TreatFlavorId serial PRIMARY KEY, FlavorId Int, TreatId INT);
    * CREATE TABLE flavors (FlavorId serial PRIMARY KEY, FlavorName LONGTEXT, TreatId INT);
* _Git clone Or download the zip file from gihub { https://github.com/JackStunning/PierresTreats.Solution }_
* _In the Terminal run this command { dotnet build }_
* _In the Terminal run this command { dotnet run }_

## Specs

  * _Spec:_ When user opens localhost:5000.
      * _Input:_ user opens web app
      * _Output:_ homepage should open "Welcome to Pierre's!" and also gives you links "See Peirre's Treats", "See Peirre's Flavors"

## Known Bugs

_No known bugs_

## Support and contact details
 
_Email: JackStunning9001@gmail.com_

## Technologies Used

_C#, .NET, MSTest, MySQL, Html, Bootstrap, Entity Framework_

### License

*Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN*

Copyright (c) 2020 **_Jack Dunning_**