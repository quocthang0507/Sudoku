---
languages:
- c#
products:
- dotnet-core
- windows
page_type: sample
name: ".NET Core Windows Forms Sudoku (C#)"
description: "Sudoku is a number puzzle game, played on a nine by nine cell grid"
---
# .NET 5.0 Windows Forms Sudoku (C#)

[https://github.com/dotnet/samples/tree/master/windowsforms/Sudoku](https://github.com/dotnet/samples/tree/master/windowsforms/Sudoku)

Sudoku is a number puzzle game, played on a nine by nine cell grid. Within thatgrid there are nine sub-regions consisting of three cells by three cells. In this version there are three levels of difficulty, which are Most clues, Medium clues, and Least clues.

Most clues gives you five random numbers from each nine cell horizontal row. Medium clues gives you four random numbers from each nine cell horizontal row. Least clues gives you three random numbers from each nine cell horizontal row.

The object of the game is to fill the remaining cells with the integers one to nine. But each horizontal row can only contain one instance of each integer, and each vertical row can only contain one instance of each integer. There is alsothe further added constraint that each sub-region can also only contain one instance of each integer.

In a new game, the given numbers (clues) are rendered in red text. The numbers that you enter are rendered in black text. There is a Solution button, which when clicked, reveals the correct answer to the puzzle. Any numbers that you have addedthat are correctly placed, remain rendered with black text. Any cells that were empty or had an incorrect integer will display the correct integer rendered inblue text.

You have won the game if after clicking the Solution button all of the numbers are rendered in either black or red text.