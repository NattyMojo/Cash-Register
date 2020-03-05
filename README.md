#Author: Zach Luciano
#Date 3/3/20
#Project: p3: C#

## Description
This program is an interpretation of a cash register for a store. The GUI takes an input of
an item name, the quantity of item, and the unit price of the item. After clicking 'Save' it
will store the item information in a table on the right side of the screen and calculate the
total based on quantity, unit price, and sales tax and display it below the list of items.

## Usage

To use the program first navigate to the directory with the files or in VS open the
"CashRegisterDriver.cs" file.
If in Visual Studio the system can be run just by running the driver file, this will open
the form window to begin using the system
The system can also be built on Windows Command Line by navigating to the source where
"CashRegisterDriver.cs" is held and running the following command (be sure .NET Framework
is in the PATH environment variable):
	$csc -out:CashRegister.exe *.cs
This will create a "CashRegister.exe" file which can then be run by just typing the file
name in the command line.
