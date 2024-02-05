# Internship_Work


# Projects are


# c# basic programs

1. swap number
	a.swap two number
	b.swap two number without using third variable

2. loop test
	choice for math operations
        a.sum avg min max a number.
        b.Other Operations.
		1. natural number
                2. natural number in reverse order
                3. even and odd number
                4. Display Table
                5. sum of first N natural numbers
                6. Count Digits in a number and sum of a number
                7. Reverse a number
   
3. if else test
	a.leap year program
	b.check number is prime or not program

<!-- 4.array test .....

  a.print array element
   -->     
4.Math test
	
	a.reverse a number.
        b.sorting a number in assending order.
        c.sorting a number in decenging order.
        d.closest palindrom number. 
        e.Area of a Circle
        f.find greater among three numbers



# Bank_Details

Form 1 (PersonsDetails):
Form 1 is designed for entering and saving bank details for individuals. It includes the following functionalities:

1. Text Fields: Allows users to input personal details such as name, contact number, and select a bank from a dropdown menu.
2. Save Button (btnSave): Saves the entered details to a text file (details.txt). If the file doesn't exist, it creates a new one.
3. Clear Button (btnClear): Clears the input fields.
4. File Open Button (btnfileopen): Opens Form 2 for displaying the stored bank details.
5. ID Management: Uses a static variable (id) to keep track of the unique ID for each entry.

Form 2 (Form2):
Form 2 is designed for displaying and querying the stored bank details. It includes the following functionalities:

1. RichTextBox (richTextBox1): Displays the entire content of the details.txt file.
2. Show Button (btnshow): Loads and displays the content of the details.txt file in the RichTextBox.
3. ComboBox (comboBox1): Allows users to select a bank name. On selection, it displays details of persons associated with the selected bank.
4. Label (label1): Displays the index of the selected bank from the ComboBox.

The application employs file handling to store and retrieve bank details, and it uses basic Windows Forms controls for user input and output

# OOP_concept


1. program.cs
This file serves as the entry point of the application. Key functionalities include:

Car Rental Platform:
Welcomes the user to a car rent search platform.
Asks the user to enter the number of car seaters (4 or 6).
Uses the Factory Method Design Pattern to create an instance of a car based on the user's input.
Displays car details and prompts the user to choose a specific car.
Asks the user for payment details and uses interfaces (Ipayment and Icardpayment) for handling different payment modes.

2. Factorymethod.cs
This file contains the implementation of the Factory Method Design Pattern. Key elements include:

Interfaces (Icar, Ipayment, Icardpayment):

Icar: Defines methods for displaying car details.
Ipayment: Defines a method for handling payments.
Icardpayment: Extends Ipayment and includes additional methods for card payments.
Car Classes (SixSeatercar, FourSeatercar):

Implement the Icar interface to provide details about different car models.
The user can choose a specific car model, and the details are displayed accordingly.
CarFactory Class:

Implements the Factory Method pattern by providing a method (getcar) to create instances of car classes based on the type of car seaters (4 or 6).

3. Class1.cs
This file defines interfaces and classes related to payment methods. Key elements include:

Interfaces (Ipayment, Icardpayment):

Ipayment: Defines a method for handling general payments.
Icardpayment: Extends Ipayment and includes additional methods specific to card payments.
Payment Classes (Gpay, Phonepay, Cardpay):

Implement the respective interfaces (Ipayment and Icardpayment) to handle different payment methods.
Internal Class (Class1):

Placeholder class, possibly auto-generated and not used in the current context.
The code structure demonstrates the use of OOP principles such as encapsulation, abstraction, and inheritance. It also employs the Factory Method pattern to create instances of car objects based on user input, promoting flexibility and extensibility in the application. Additionally, interfaces are used to define contracts for different payment methods, allowing for easy integration of new payment types in the future.



# Database_Demo

This mini project is a simple authentication system implemented in C# using Windows Forms. It consists of three forms: Form1 for user login, AdminHome for the admin's home interface, and UserHome for the user's home interface.

Form1 (Login Form)
Functionality:
Takes user credentials (username and password) as input.
Connects to a SQL Server database to validate the credentials.
If valid, opens a new form based on the user type (admin or user).
If invalid, displays an error message.

AdminHome Form
Functionality:
Displays a welcome message for the admin.
Inherits from the generic Form class.
Utilizes the provided admin username to personalize the interface.
Opens upon successful authentication of an admin user.

UserHome Form
Functionality:
Displays a welcome message for a regular user.
Inherits from the generic Form class.
Utilizes the provided username to personalize the interface.
Opens upon successful authentication of a regular user.

Key Features:

Forms Interaction:
Implements communication between forms using constructor parameters, passing user details from the login form to the respective home forms.

User Authentication:
Validates user credentials against the database and distinguishes between admin and regular user logins.
Error Handling:

Provides informative error messages for unsuccessful login attempts or database connection issues.
This mini project serves as a foundational example of user authentication and interface customization based on user roles within a Windows Forms application. 
