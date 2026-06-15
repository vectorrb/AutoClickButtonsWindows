# AutoClickButtons

A simple Windows Forms app built with .NET 8 (`net8.0-windows`) for automating button-click workflows with cursor activity.

## Project Structure

- `AutoClickButtons.sln` - Solution file
- `AutoClickButtons/` - Main WinForms project
- `AutoClickButtons/Form1.cs` - Main form logic
- `AutoClickButtons/Program.cs` - Application entry point

## Prerequisites

- Windows OS
- .NET SDK 8.0+
- Visual Studio 2022 (or later) with **.NET desktop development** workload

## Build and Run

### Using Visual Studio

1. Open `AutoClickButtons.sln`.
2. Set build configuration to **Debug** (or **Release**).
3. Press **F5** to run.

### Using .NET CLI

From the repository root:

```powershell
dotnet restore .\AutoClickButtons.sln
dotnet build .\AutoClickButtons.sln
dotnet run --project .\AutoClickButtons\AutoClickButtons.csproj
```

## Output

Build artifacts are generated under:

- `AutoClickButtons/bin/`
- `AutoClickButtons/obj/`

## Notes

- This project targets Windows desktop and must be run on Windows.
- If execution is blocked, ensure required permissions and antivirus settings allow UI automation behavior.
