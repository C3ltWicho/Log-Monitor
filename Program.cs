using System;
using System.IO;

class LogMonitor
{
    static void Main(string[] args)
    {
        string logFilePath = "log.txt";
        
        // Check if the log file exists
        if (!File.Exists(logFilePath))
        {
            Console.WriteLine("Log file not found.");
            return;
        }

        Console.WriteLine("Monitoring log file for warnings and errors...");

        // Read initial lines
        var lastReadPosition = 0L; // Track the last read position in the file
        while (true)
        {
            // Open the log file and read new entries
            using (var fs = new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs))
            {
                // Move to the last read position in the file
                sr.BaseStream.Seek(lastReadPosition, SeekOrigin.Begin);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Detect keywords
                    if (line.Contains("ERROR"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"[ALERT] {line}");
                        Console.ResetColor();
                    }
                    else if (line.Contains("WARN"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"[WARNING] {line}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(line); // Regular log line
                    }

                    // Update the last read position
                    lastReadPosition = sr.BaseStream.Position;
                }
            }

            // Sleep for 2 seconds before checking the file again
            System.Threading.Thread.Sleep(2000);
        }
    }
}
