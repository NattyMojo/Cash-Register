#Author: Zach Luciano
#Date 3/3/20
#Project: p3: C#

## Description
This program is an interpretation of a cash register for a store. The GUI takes an input of
an item name, the quantity of item, and the unit price of the item. After clicking 'Save' it
will store the item information in a table on the right side of the screen and calculate the
total based on quantity, unit price, and sales tax and display it below the list of items.

## Usage

!!Please grade using VS or Windows Command Line!!

To use the program first navigate to the directory with the files or in VS open the
"CashRegisterDriver.cs" file.
===
If in Visual Studio the system can be run just by running the driver file, this will open
the form window to begin using the system
===
===
The system can also be built on Windows Command Line by navigating to the source where
"CashRegisterDriver.cs" is held and running the following command (be sure .NET Framework
is in the PATH environment variable):
	$csc -out:CashRegister.exe *.cs
This will create a "CashRegister.exe" file which can then be run by just typing the file
name in the command line.
===

## Differences Between C# and Java & IDE Experience
There really are not that many differences between C# and Java, as I found through this
project. The biggest difference is namespace, though it is much like the packages in Java.
Some syntax is slightly different, for instance System.out.println() in Java is
Console.WriteLine() in C#. I do like C# slightly more than Java after completing this
project, there is a simplicity to GUIs in C# that Java is lacking in. 

I found Visual Studio to be very intuitive once I was able to get it running, that's the 
hard part! After workingout some kinks, everything came together very easily and the connections
made between files are very smooth and easier to handle. Visual Studio takes time to learn how 
to navigate and is not very welcoming when first starting a project, but once you figure it out
it's not so bad.
