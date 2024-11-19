This is a .NET 7 Console Application that generates daily log files organized by month and year. The application is designed to be run via a task scheduler, logging the start and end times of its execution.

Features
Daily Log Files: Creates a log file for the current day with a timestamp for when the application starts and ends.
Organized Structure: Log files are stored in a structured directory:
css
Copy code

Logs/
└── November-2024/
    └── 2024-11-20.log
Automatic Folder Creation: Automatically creates the Logs folder and monthly subfolders if they don’t exist.
