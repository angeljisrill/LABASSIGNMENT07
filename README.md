[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/GM5FbND1)
# Lab Assignment 07 - Simple Calculator

## Assignment Overview
In this lab assignment, you will complete a fully functional Windows Forms calculator application with an attractive user interface design. The project has been started for you with basic button functionality, but you need to complete it to make it a working calculator.

## Learning Objectives
By completing this assignment, you will:
- Gain experience with Windows Forms applications in .NET
- Understand event-driven programming
- Implement mathematical operations in a GUI application
- Apply design principles to create an attractive user interface
- Handle user input validation and error cases

## Requirements

### Functional Requirements
Your calculator must support the following operations:

1. **Basic Arithmetic Operations**
   - Addition (+)
   - Subtraction (-)
   - Multiplication (×)
   - Division (÷)

2. **Number Input**
   - Digits 0-9
   - Decimal point support
   - Clear/Reset functionality (C or CE)
   - Backspace/Delete last digit

3. **Display**
   - Show current input
   - Display calculation results
   - Handle error messages (e.g., division by zero)

### Design Requirements
Your calculator must have a professional and attractive appearance:

1. **Layout**
   - Well-organized button grid
   - Clear and readable display area
   - Consistent spacing and alignment
   - Appropriate sizing for usability

2. **Visual Design**
   - Use a cohesive color scheme
   - Apply custom colors to different button types (numbers, operators, special functions)
   - Use appropriate fonts (readable, professional)
   - Add visual feedback (hover effects, button press states)
   - Consider modern UI design principles (flat design, material design, or similar)

3. **User Experience**
   - Intuitive button placement
   - Clear visual hierarchy
   - Responsive feedback to user actions
   - Error handling with user-friendly messages

## Project Structure
```
LabAssignment07/
├── Form1.cs              # Main form code-behind (your work goes here)
├── Form1.Designer.cs     # UI designer code
├── Program.cs            # Application entry point
├── LabAssignment07.csproj # Project file
└── README.md             # This file
```

## Getting Started

### Current State
The project currently has:
- A basic Windows Form
- Two button click handlers (button1 and button2) that append "1" and "2" to a textbox
- Basic form structure

### What You Need to Do

1. **Design the Calculator UI**
   - Open Form1 in the Designer view
   - Add a TextBox for the display
   - Add buttons for:
     - Numbers (0-9)
     - Operations (+, -, ×, ÷)
     - Equals (=)
     - Clear (C)
     - Decimal point (.)
     - Optional: Additional functions
   - Apply colors, fonts, and styling

2. **Implement Calculator Logic**
   - Create variables to store:
     - Current input value
     - Previous value
     - Current operation
   - Implement number button handlers
   - Implement operation button handlers
   - Implement equals functionality
   - Handle special cases (decimal points, leading zeros, etc.)

3. **Add Error Handling**
   - Division by zero
   - Invalid operations
   - Number overflow

4. **Polish the Design**
   - Test all functions
   - Ensure visual consistency
   - Add finishing touches

## Implementation Tips

### Calculator Logic Example
```csharp
// You'll need variables like:
private double currentValue = 0;
private double previousValue = 0;
private string operation = "";
private bool isOperationPerformed = false;

// Number button pattern:
private void btnNumber_Click(object sender, EventArgs e)
{
    Button btn = (Button)sender;
    if (isOperationPerformed)
    {
        txtDisplay.Clear();
        isOperationPerformed = false;
    }
    txtDisplay.Text += btn.Text;
}

// Operation button pattern:
private void btnOperation_Click(object sender, EventArgs e)
{
    Button btn = (Button)sender;
    previousValue = double.Parse(txtDisplay.Text);
    operation = btn.Text;
    isOperationPerformed = true;
}

// Equals button:
private void btnEquals_Click(object sender, EventArgs e)
{
    // Perform the calculation based on the operation
    // Display the result
}
```

### Design Tips
- **Color Scheme Examples:**
  - Numbers: Light gray or blue
  - Operators: Orange or accent color
  - Equals: Green or bright accent
  - Clear/Special: Red or dark gray
  - Display: White or light background

- **Font Recommendations:**
  - Display: Large, clear font (e.g., Segoe UI, 18-24pt)
  - Buttons: Medium, bold font (e.g., Segoe UI, 12-14pt)

## Testing Your Calculator
Test the following scenarios:
- [ ] Basic addition: 5 + 3 = 8
- [ ] Basic subtraction: 10 - 4 = 6
- [ ] Basic multiplication: 7 × 6 = 42
- [ ] Basic division: 20 ÷ 4 = 5
- [ ] Division by zero: 5 ÷ 0 (should show error)
- [ ] Decimal operations: 3.5 + 2.5 = 6
- [ ] Chain calculations: 5 + 3 = (8) + 2 = (10)
- [ ] Clear functionality
- [ ] Multiple decimal points (should be prevented)

## Submission Guidelines
1. Ensure your code is well-commented
2. Test all functionality thoroughly
3. Take a screenshot of your calculator design
4. Submit the following:
   - Complete project folder (or GitHub repository link)
   - Screenshot of running application
   - Brief description of any extra features implemented

## Grading Rubric

| Criteria | Points |
|----------|--------|
| **Functionality (50%)** | |
| - All number buttons work correctly | 10 |
| - All arithmetic operations work correctly | 20 |
| - Clear/Reset functionality | 5 |
| - Decimal point handling | 5 |
| - Error handling (division by zero, etc.) | 10 |
| **Design (30%)** | |
| - Attractive color scheme | 10 |
| - Professional layout and organization | 10 |
| - Appropriate fonts and sizing | 5 |
| - Visual polish and attention to detail | 5 |
| **Code Quality (20%)** | |
| - Clean, readable code | 7 |
| - Proper event handler implementation | 7 |
| - Comments and documentation | 6 |
| **Extra Credit (up to 10%)** | |
| - Additional features | 5 |
| - Exceptional design | 3 |
| - Keyboard support | 2 |

## Resources
- [Windows Forms Documentation](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)
- [Color Picker Tool](https://htmlcolorcodes.com/)
- [Google Fonts](https://fonts.google.com/)

## Help and Support
If you encounter issues:
1. Review the lecture materials on Windows Forms
2. Check the documentation links above
3. Attend office hours
4. Post questions on the course discussion board


Good luck, and have fun creating your calculator! 🧮

---
*Lab Assignment 07 - .NET 10.0 Windows Forms Application*
<img width="1361" height="640" alt="Screenshot 2026-04-25 141547" src="https://github.com/user-attachments/assets/07ada5c4-7d09-4bf7-8724-a1543b2c6c9f" />



