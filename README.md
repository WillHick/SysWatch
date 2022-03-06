# SysWatch Beta (1.1.3)

# About
The app is a simple C# WPF application and will provide you with counts and a feed with the data detected down below is what SysWatch will detect and display in counts.

# Detects
SysWatch is a C# Windows application using the FileSystemWatcher component to detect the following :

  - How many changes in files has there been
  - How many files have been deleted
  - How many files have been renamed
  - How many files have been moved

# UI
Main Display (1.1.3)

<img width="123" alt="SysWatch1 1 3UI" src="https://user-images.githubusercontent.com/48844761/156912745-b371782a-a334-4049-ac96-52ab5ed141a3.PNG">


More Display (1.1.3)

<img width="300" alt="SysWatch1 1 3UIDoubleClick" src="https://user-images.githubusercontent.com/48844761/156912768-9e877ccd-030e-4f5d-84fd-efe027a8d4d8.PNG">


# Help
Commonly Seen:
  - When I press reset numbers will not return to "0" - Ans : This is because a process from the FileSystemWatcher component will be running and detecting at all times.
  - Can I stop the FileSystemWatcher component and pause the count - Ans : No you cant, to turn off simply close the application
  - The Live Feed is displatying so much information at once - Ans : The feed will show every event at the time of event, this means when lots happens it will display it quickly     followed by the next action
  - Updates - Ans : Often updates will arrive
  - The app wont save current values each time I close/restart - Ans : No form of data saving here, it detects and displays, no interent needed, see the code for yourself, the       small tool is standalone
