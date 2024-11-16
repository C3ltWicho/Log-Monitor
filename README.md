
# Log Monitor

A simple C# application to monitor a log file (`log.txt`) for warnings and errors. The program continuously reads the log file and highlights lines containing `ERROR` or `WARN` to make them easily identifiable.

## Features

- **Real-Time Monitoring**: The log file is continuously monitored for updates, and new entries are displayed immediately.
- **Color-Coded Alerts**:
  - `ERROR` messages are displayed in **red**.
  - `WARN` messages are displayed in **yellow**.
- Regular log lines are displayed without any color modifications.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.
- Basic knowledge of the command line or terminal.

### Running the Application

1. **Clone the Repository**:
   
   ```bash
   git clone https://github.com/your-username/log-monitor.git
   cd log-monitor
   ```

2. **Create or Provide a Log File**:

   Ensure there's a `log.txt` file in the root directory. If it doesn't exist, create one:

   ```bash
   touch log.txt
   ```

3. **Build and Run the Application**:

   ```bash
   dotnet build
   dotnet run
   ```

   Alternatively, you can compile and run it with:

   ```bash
   dotnet run LogMonitor.cs
   ```

4. **Monitoring the Log File**:

   - The application will start monitoring `log.txt`.
   - You can simulate log updates by appending lines to `log.txt` while the program is running.

### Usage Example

Here's an example of what your `log.txt` file might look like:

```
2024-11-14 12:00:01 INFO Application started.
2024-11-14 12:01:23 WARN Low disk space on drive C:.
2024-11-14 12:02:10 INFO User logged in.
2024-11-14 12:03:55 ERROR Failed to connect to database.
```

The log monitor will highlight the `WARN` and `ERROR` entries in color.

## Customization

Feel free to modify the code to adjust log levels, keywords, or file paths. For example, to change the log file path, update the `logFilePath` variable:

```csharp
string logFilePath = "your-log-file.txt";
```

## Troubleshooting

- **Log File Not Found**: Ensure the `log.txt` file exists in the same directory as the executable. If it's in another location, update the `logFilePath` variable.
- **Permissions**: Make sure you have the necessary read permissions for the log file.

## Contributing

If you'd like to contribute to the project:

1. Fork the repository.
2. Create a new branch: `git checkout -b feature-branch-name`.
3. Make your changes and commit them: `git commit -m 'Add some feature'`.
4. Push the changes: `git push origin feature-branch-name`.
5. Submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- Inspired by the need for simple log monitoring in various environments.
- Uses C#'s `FileStream` and `StreamReader` for file reading.

## Contact

For any questions or feedback, feel free to reach out!
