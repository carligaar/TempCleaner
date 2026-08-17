# TempCleaner

Clean Windows temporary files quickly and safely, freeing up disk space in a couple of clicks.

## What it does
- Deletes every file inside `C:\Windows\Temp`
- Removes the empty subfolders left behind afterward
- Skips any file that's locked or in use instead of crashing
- Shows a summary of how many files and folders were removed

## Tech
C# · Windows Forms (.NET)

## Run it
Clone the repo and open it in Visual Studio, or run `dotnet run` from the project folder. Some system files may require running as administrator to be deleted.
