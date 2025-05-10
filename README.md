# Basic Calculator 🧮

This project is a simple GUI-based calculator built using C# and Windows Forms. It performs basic arithmetic operations such as addition, subtraction, multiplication, and division. The calculator is designed to be intuitive, with a clean and aesthetically pleasing interface. ✨

## Project Overview
The application is a basic calculator with the following features:
- **Numeric Input (0-9) 🔢**: Buttons for numbers 0 through 9.
- **Operators ➕➖✖️➗**: Addition, subtraction, multiplication, and division.
- **Special Buttons 🧹**: Clear Entry (CE), Clear (C), Decimal Point (.), and Equals (=).
- **Aesthetic Design 🎨**: Customizable font styles, sizes, and colors.

## Instructions for Setup 🛠️

### Form Properties
1. **Appearance**:
    - Text: `Basic Calculator 🧮`
    - FormBorderStyle: `Fixed Single` 🔒
    - Customize font styles, sizes, backgrounds, and colors. 🎨
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

## How to Run ▶️
1. Open the project in Visual Studio. 🛠️
2. Build and run the application using the Start button. 🚀
3. Interact with the calculator to perform calculations. ✍️

<h2>Sample Output</h2>

<p align="center">
  <img src="https://github.com/user-attachments/assets/c9563096-4367-4ae6-a90a-3e88054d5a46" width="45%" />
  <img src="https://github.com/user-attachments/assets/de76aea3-18fc-4b54-a389-ccba67ee91f9" width="45%" />
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/346d52a9-5a82-4e74-a56b-6a3138d9417a" width="45%" />
  <img src="https://github.com/user-attachments/assets/4a5fb285-ca8d-4fc7-a84e-2d9e35b8969c" width="45%" />
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/5647aa44-92a1-46f7-8244-3aa5205ddd44" width="45%" />
  <img src="https://github.com/user-attachments/assets/a3bcfea6-5c72-4bfc-afa0-d09ee832fba7" width="45%" />
</p>

## Contact ✉️
If you encounter any issues or need further assistance, feel free to reach out!
