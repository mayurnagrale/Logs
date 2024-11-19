// Define the folder structure
string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
string logsDirectory = Path.Combine(baseDirectory, "Logs"); // Logs folder in base directory
string monthFolderName = DateTime.Now.ToString("MMMM-yyyy"); // Example: "November-2024"
string monthDirectory = Path.Combine(logsDirectory, monthFolderName); // Logs/November-2024
string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log"; // Example: "2024-11-20.log"
string logFilePath = Path.Combine(monthDirectory, logFileName);

// Ensure the Logs and month directory exists
if (!Directory.Exists(monthDirectory))
{
    Directory.CreateDirectory(monthDirectory);
}

// Write log entry for service start
LogEvent(logFilePath, "Service started");

// Simulate some work here if needed
System.Threading.Thread.Sleep(2000); // Example 2-second delay

// Write log entry for service end
LogEvent(logFilePath, "Service ended");


static void LogEvent(string filePath, string message)
{
    string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
    File.AppendAllText(filePath, logEntry + Environment.NewLine);
}