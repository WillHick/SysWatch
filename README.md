# SysWatch Beta 

# About
The app is a simple C# WPF application and will provide you with counts and a feed with the data detected down below is what SysWatch will detect and display in counts.

# Detects
SysWatch is a C# Windows application using the FileSystemWatcher component to detect the following :

  - How many changes in files has there been
  - How many files have been deleted
  - How many files have been renamed
  - How many files have been moved

# UI
Main Display

<img width="124" alt="SWSnip" src="https://user-images.githubusercontent.com/48844761/155839377-b76f4aea-3d8e-48f8-b895-6116707d01a0.PNG">

Live Feed Display

<img width="500" alt="SWSnip2" src="https://user-images.githubusercontent.com/48844761/155839393-7cf7bd8c-19bc-4e3f-b852-9e28d8a9e257.PNG">


# Help
Commonly Seen:
  - When I press reset numbers will not return to "0" - Ans : This is because a process from the FileSystemWatcher component will be running and detecting at all times.
  - Can I stop the FileSystemWatcher component and pause the count - Ans : No you cant, to turn off simply close the application
  - The Live Feed is displatying so much information at once - Ans : The feed will show every event at the time of event, this means when lots happens it will display it quickly     followed by the next action
  - Updates - Ans : Often updates will arrive
  - The app wont save current values each time I close/restart - Ans : No form of data saving here, it detects and displays, no interent needed, see the code for yourself, the       small tool is standalone
