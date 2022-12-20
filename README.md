![version](https://img.shields.io/badge/version-1.0.0-blue)
![GitHub repo size](https://img.shields.io/github/repo-size/ngdechev/football-championship?color=yellow)
![Bitbucket open issues](https://img.shields.io/bitbucket/issues/ngdechev/football-championship)

# Software Production Technology Project
## Assignment - "Taxi Management Application"

To create a Vaccine application. For this purpose, three forms should be added.
1. Add the controls to the first **Form1** (Input):
- Labels:
  - Username
  - Password
- Text fields:
  - To enter username (textBox1)
  - To enter a password (textBox2)
- Button:
  - "Forward" <br>

**To validate:**
- textBox1 - to allow five to ten characters to accept the numbers one to five and uppercase Latin letters, with the first character in the string not being a number.
- textBox2 - to allow five to eight characters, no limit. <br>
2. If the input data is correctly set and an appropriate message is displayed, start **Form2** (Personal data). Add the controls to it:
- Labels:
  - Name
  - Surname
  - EGN
  - Years
  - Date of birth
- Group (Gender) with two radio buttons:
  - A man
  - A woman
- Text fields:
  - To enter a name (textBox1)
  - To enter last name (textBox2)
  - To enter the social security number (textBox3)
  - To enter years (textBox4)
- Date and time selection field:
  - To enter a date of birth (datetimePicker1)
- Button:
  - "Forward" <br>

**To validate:**
- textBox1 and textBox2 - intended for the patient's name, to start with a Cyrillic capital letter followed by lowercase letters
- textBox3 - must allow ten characters - numbers from 0 to 9
- textBox4 - to return the result of the calculated difference between the current date and the date of birth, from the string for the entered EGN
- datetimePicker1 - loads the date of birth, depending on the first 6 characters in the EGN input string.

If the EGN is correctly set, mark one of the two radio buttons (radioButton1 or radioButton2). Taking into account the ninth character in the EGN string, and with an even value, the marker falls on radioButton1, and with an odd value, on radioButton2.
3. With correctly set input data, an appropriate message should be displayed and after it a third Form3 (Vaccines) should be launched. Add the controls to it:
- Group of three radio buttons:
  - Hepatitis B (First intake) (radioButton1)
  - BCG vaccine (radioButton2)
  - ThetaDiff vaccine (radioButton3)
- Button:
  - "Forward" <br>

Condition for active radio button from Form3:
- If the patient's years calculated in Form2 are from 1 to 6 years, to automatically mark radioButton1
- If the patient's years calculated in Form2 are from 7 to 12 years, to automatically mark radioButton2
- If the patient's age calculated in Form2 is from 13 to 18 years, to automatically mark radioButton3

All data from Form2 and Form3 should be saved in an Excel file after clicking on the button "Save in Excel file" from Form3 (Vaccines).
## Test the Application
### Sample Input Data:
- Username: *qwerty*
- Password: *qwe?*
- EGN: *5907204688*

## Project Development
The following programming languages were used for the development of the project:
1. C#

And the following tools:
1. Visual Studio 2022
2. Microsoft Excel 2016
<br>

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![SQL](https://img.shields.io/badge/-SQL-blue?style=for-the-badge) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) ![Microsoft Excel](https://img.shields.io/badge/Microsoft_Excel-217346?style=for-the-badge&logo=microsoft-excel&logoColor=white)

## Contributors

<a href="https://github.com/ngdechev/taxi-management-application/graphs/contributors">
<img src="https://contributors-img.web.app/image?repo=ngdechev/taxi-management-application" />
</a>

## Screenshots of the program execution
### Login Form
![2.png](https://i.postimg.cc/sD1xptk6/2.png)

### Pacient Info Form
![3.png](https://i.postimg.cc/2y95swZ7/3.png)

### Vaccines Form
![4.png](https://i.postimg.cc/44WnHJSH/4.png)

### Excel Screenshot
![1.png](https://i.postimg.cc/fyRLqFJb/1.png) 
