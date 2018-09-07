# <p align="center"> C# Intro And Basic Syntax - Exercises <p>

## 01. Debit Card Number

Write a program, which receives **4 integers** on the console and **prints them** in **4-digit debit card format**. See the examples below for the appropriate formatting.

#### Examples

|**Input**|**Output**|
|---|---|
|12 <br/> 433 <br/> 1 <br/> 5331|0012 0433 0001 5331|
|9182 <br/> 4221 <br/> 12 <br/> 3|9182 4221 0012 0003|
|812 <br/> 321 <br/> 123 <br/> 22|0812 0321 0123 0022|

## 02. Rectangle Area
Write a program, which calculates a **rectangle’s area**, based on its **width** and **height**. The width and height come as floating point numbers on the console, **formatted to the 2nd character after the decimal point**.

#### Examples

|**Input**|**Output**|
|---|---|
|2 <br/> 7|14.00|
|7 <br/> 8|56.00|
|12.33 <br/> 5|61.65|

## 03. Miles to Kilometers
Write a program, which **converts miles to kilometers**. Format the output to the **2nd decimal place**.
Note: **1 mile == 1.60934 kilometers**

#### Examples

|**Input**|**Output**|
|---|---|
|60     |96.56|
|1      |1.61|
|52.1113|83.86|

## 04. Beverage Labels
Write a program, which reads a food product name, volume, energy content per 100ml and sugar content per 100ml. Calculate the energy and sugar content for the given volume and print them on the console in the following format:
- Name – as per the input
- Volume – **integer, suffixed by “ml” (e.g. “220ml”)**
- Energy content – **integer, suffixed by “kcal” (e.g. “500kcal”)**
- Sugar content – **real number, suffixed by “g” (e.g. “30g”)** 

#### Examples

|**Input**|**Output**|
|---|---|
|Nuka-Cola <br/> 220 <br/> 300 <br/> 70|220ml Nuka-Cola: <br/> 660kcal, 154g sugars|
|Ice Cold Nuka-Cola <br/> 250 <br/> 350 <br/> 65|250ml Ice Cold Nuka-Cola: <br/> 875kcal, 162.5g sugars|
|Nuka-Cola Quantum <br/> 350 <br/> 600 <br/> 140|350ml Nuka-Cola Quantum: <br/> 2100kcal, 490g sugars|

## 05. * Character Stats
Write a program, which displays information about a video game character. You will receive their **name, current health, maximum health, current energy and maximum energy** on separate lines. The current values will always be valid (equal or lower than their respective max values). Print them in the format as per the examples.

#### Examples

|**Input**|**Output**|
|---|---|
|Mayro <br/> 5 <br/> 10 <br/> 9 <br/> 10|Name: Mayro <br/> Health: \|\|\|\|\|\|.....\| <br/> Energy: \|\|\|\|\|\|\|\|\|\|.\|

## 07.Advertisement Message
Write a program that **generate random fake advertisement message** to extol some product. The messages must consist of 4 parts: laudatory **phrase + event + author + city**. Use the following predefined parts:
- **Phrases** – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}
- **Events** – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}
- **Author** – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
- **Cities** – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}
The format of the output message is: **{phrase} {event} {author} – {city}**.
As an input you take the **number of messages** to be generated. Print each random message at a separate line.

#### Examples

|**Input**|**Output**|
|---|---|
|3|Such a great product. Now I feel good. Elena – Ruse <br/> Excelent product. Makes miracles. I am happy of the results! Katya – Varna <br/> Best product of its category. That makes miracles. Eva - Sofia|

> #### Hints
> - Hold the **phrases, events, authors** and **towns** in 4 arrays of strings.
> - Create **Random** object and **generate 4 random numbers** each in its range:
> phraseIndex -> [0, phrases.Length)
> eventIndex -> [0, events.Length)
> authorIndex -> [0, authors.Length)
> townIndex -> [0, towns.Length)
> - Get one **random element** from each of the four arrays and **compose a message** in the required format.

## 08.Average Grades
Define a class **Student**, which holds the following information about students: **name, list of grades** and **average grade** (calculated property, read-only). A single grade will be in range [2…6], e.g. 3.25 or 5.50.
Read a **list of students** and print the students that have **average grade ≥ 5.00** ordered **by name** (ascending), then by **average grade** (descending). Print the student name and the calculated average grade.

#### Examples

|**Input**|**Output**|
|---|---|
|3 <br/> Ivan 3 <br/> Todor 5 5 6 <br/> Diana 6 5.50|Diana -> 5.75 <br/> Todor -> 5.33|
|6 <br/> Petar 3 5 4 3 2 5 6 2 6 <br/> Mitko 6 6 5 6 5 6 <br/> Gosho 6 6 6 6 6 6 <br/> Ani 6 5 6 5 6 5 6 5 <br/> Iva 4 5 4 3 4 5 2 2 4 <br/> Ani 5.50 5.25 6.00|Ani -> 5.58 <br/> Ani -> 5.50 <br/> Gosho -> 6.00 <br/> Mitko -> 5.67|

> #### Hints
> - Create class **Student** with properties **Name (string), Grades (double[])**, and property **AverageGrade** (calculated by LINQ as **Grades.Average()**, read-only).
> - Make a **list of students** and **filter with LINQ** all students that has average **grade >= 5.00**.
> - Print the filtered students **ordered by name** in ascending order, then by **average grade** in descending order.

## 09.Book Library 
To model a **book library**, define classes to hold a **book** and a **library**. The library must have a **name** and a **list of books**. The books must contain the **title, author, publisher, release date, ISBN-number** and **price**. 
Read a **list of books**, add them to the library and print the **total sum of prices by author**, ordered **descending by price** and **then by author’s name lexicographically**.
Books in the input will be in format **{title} {author} {publisher} {release date} {ISBN} {price}**.

#### Examples

|**Input**|**Output**|
|---|---|
|5 <br/> LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00 <br/> Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25 <br/> HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50 <br/> HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00 <br/> AC OBowden PenguinBooks 20.11.2009 0395082555 14.00|Tolkien -> 40.25 <br/> JKRowling -> 35.50 <br/> OBowden -> 14.00|

> #### Hints
> - Create classes **Book** and **Library** with all the mentioned above properties. 
![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/files1.png)
> - **Create** an object of type **Library**.
> - **Read the input** and create a **Book** object for each book in the input.
> - Create a **LINQ** query that will **sum the prices by author, order the results** as requested.
> - **Print** the results.

## 10.Book Library Modification
Use the classes from the previous problem and make a program that **read a list of books** and **print all titles released after given date** ordered **by date** and then **by title lexicographically**. The date is given if format **“day-month-year”** at the last line in the input.

#### Examples

|**Input**|**Output**|
|---|---|
|5 <br/> LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00 <br/> Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25 <br/> HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50 <br/> HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00 <br/> AC OBowden PenguinBooks 20.11.2009 0395082555 14.00 <br/> 30.07.1954|HP1 -> 26.06.1997 <br/> HP7 -> 21.07.2007 <br/> AC -> 20.11.2009|