# speedtest_comp

`speedtest_comp` is a command-line tool for benchmarking and testing the performance of various components of your PC, including the CPU, RAM, Disk, and Network. This tool helps you quickly evaluate the health and performance of your system, providing useful metrics that can guide optimization and troubleshooting.

## Features

- **CPU Speed Test**: Measures the performance of your CPU by running computational benchmarks.
- **RAM Speed Test**: Tests the read/write speed of your system's RAM.
- **Disk Speed Test**: Assesses the read and write speeds of your storage devices (HDD/SSD).
- **Network Speed Test**: Measures the upload and download speeds of your internet connection.
  
## Requirements

- .NET Core 8.0 or higher
- A compatible Windows system (the tool may be optimized for other platforms in the future)
  
## Installation

To get started with `speedtest_comp`, follow these steps:

1. Clone the repository to your local machine:
    ```bash
    git clone https://github.com/yourusername/speedtest_comp.git
    ```

2. Navigate to the project directory:
    ```bash
    cd speedtest_comp
    ```

3. Build the project using Visual Studio or the .NET CLI:
    ```bash
    dotnet build
    ```

4. Run the application:
    ```bash
    dotnet run
    ```

## Usage

Once the tool is running, you'll be prompted to choose an option:

```bash
Speed Test Tool
Select an option:
1. Run CPU Speed Test
2. Run RAM Speed Test
3. Run Disk Speed Test
4. Run Network Speed Test
5. Exit
```

Simply select the test you want to run by entering the corresponding number. After the test is complete, the tool will return to the main menu, allowing you to select additional tests or exit the application.

## Contributing

We welcome contributions to `speedtest_comp`. If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add new feature'`).
5. Push to your forked repository (`git push origin feature-name`).
6. Open a pull request.

## License

`speedtest_comp` is open-source software released under the [MIT License](https://github.com/moxiuoqoo/speedtest_comp/blob/main/LICENSE).
