# Basic Calculator 🧮   
<table>
  <tr>
    <td>
      <img src="https://github.com/user-attachments/assets/12ba7e16-c56d-4849-8d94-f966257a1035" width="300" height="150">
    </td>
    <td>
      <img src="https://github.com/user-attachments/assets/fbbe0463-e2a2-4029-99a2-46e60b68c487" width="300" height="150">
    </td>
    <td style="vertical-align: top; padding-left: 20px;">
      This project is a simple C# Windows Forms calculator that performs basic arithmetic operations—addition, subtraction, multiplication, and division—with support for decimals, a history log, and a theme toggle. It features a clean, user-friendly interface with responsive buttons and event-driven logic, making it both functional and aesthetically pleasing. ✨
    </td>
  </tr>
</table>


## Project Overview
The application is a basic calculator with the following features:
- **Numeric Input (0-9) 🔢**: Buttons for numbers 0 through 9.
- **Operators ➕➖✖️➗**: Addition, subtraction, multiplication, and division.
- **Special Buttons 🧹**: Clear Entry (CE), Clear (C), Decimal Point (.), and Equals (=).
- **Aesthetic Design 🎨**: Customizable colors.

## Instructions for Setup 🛠️

### Form Properties
1. **Appearance**:
    - Text: `Basic Calculator 🧮`
    - FormBorderStyle: `Fixed Single` 🔒
    - Customize colors. 🎨
2. **Design**:
    - Name: `frmCalculator` 🖼️
3. **Layout**:
    - StartPosition: `Center Screen` 🎯
4. **Window Style**:
    - MaximizeBox: `False` 🚫

### Controls 🖱️
Add the following controls to the form:

| Control                | Name        | Property Value               |
|------------------------|-------------|------------------------------|
| Text Box               | txtInput    | ✏️                            |
| Button (0-9)           | btn<Number> | Example: `btn1` 🔢            |
| Clear Entry (CE)       | btnCE       | `CE` 🧹                       |
| Clear (C)              | btnClear    | `C` 🧽                        |
| Addition (+)           | btnAdd      | `➕`                          |
| Subtraction (-)        | btnMinus    | `➖`                          |
| Multiplication (*)     | btnMultiply | `✖️`                         |
| Division (/)           | btnDivide   | `➗`                          |
| Equal (=)              | btnEqual    | `=` ✅                        |
| Point (.)              | btnPoint    | `.` 🔘                        |
| Theme Toggle Button    | `btnToggleTheme` | Switches theme 🌗               |
| History Box            | `lstHistory` | Displays calculation history 📜   |

### Event Handlers ⚙️
- `button_click`: Handles all number and decimal inputs.
- `operator_click`: Handles arithmetic operations.
- `btnEqual_Click`: Computes the expression.
- `btnCE_Click`, `btnC_Click`: Clear entry and full reset.
- `btnToggleTheme_Click`: Theme switching logic.

## Expected Output ✅
The calculator should:
1. Accept numeric input via buttons. 🔢
2. Perform basic arithmetic operations. ➕➖✖️➗
3. Clear the input field when CE or C is pressed. 🧹
4. Display results in the `txtInput` text box. 📋

## Customization 🎨
Feel free to adjust the layout and appearance to suit your preferences, as long as the calculator behaves as described. 🌟

## Tools Used 🛠️
- **Microsoft Visual Studio**: IDE for developing the Windows Forms application. 🖥️
- **C#**: Programming language for logic implementation. 🖋️
- **Windows Forms**: GUI framework for building the interface.

## How to Run ▶️
1. Open the project in Visual Studio. 🛠️
2. Build and run the application using the Start button. 🚀
3. Interact with the calculator to perform calculations. ✍️

----
<h2>Sample Output 🔢 </h2>

<p align="center">
  <img src="https://github.com/user-attachments/assets/af0070ae-9a3f-4556-a840-3067a8c5bc05" width="45%" />
  <img src="https://github.com/user-attachments/assets/1fdfc39a-1d4d-4d2b-976d-78d49d9e2d10" width="45%" />
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/346d52a9-5a82-4e74-a56b-6a3138d9417a" width="45%" />
  <img src="https://github.com/user-attachments/assets/4a5fb285-ca8d-4fc7-a84e-2d9e35b8969c" width="45%" />
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/5647aa44-92a1-46f7-8244-3aa5205ddd44" width="45%" />
  <img src="https://github.com/user-attachments/assets/a3bcfea6-5c72-4bfc-afa0-d09ee832fba7" width="45%" />
</p>

----
## Contact ✉️
Found a bug or want to suggest a feature? Feel free to open an issue or drop a message!


> _"Simplicity is the soul of efficiency." — Austin Freeman_ ✨
