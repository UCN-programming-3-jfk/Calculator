# A simple Windows Forms calculator

![image](https://github.com/user-attachments/assets/39ff40b3-dd7d-417d-8483-44c579520274)

## Note
-  there is no code in the button click eventhandlers, but the code calls specific methods with only the functionality. This is done to enable calling the functionality from different places without having to simulate a button click, for example keyboard shortcuts, command line, etc.
-   validating input and giving error messages is handled in separate functions, and are called from the functionality methods (Add, Divide, etc.).
