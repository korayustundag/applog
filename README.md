# Applog
Log tool for applications

## Installation
1. [Download applog.dll](https://github.com/korayustundag/applog/raw/master/Released%20Versions/AppLog_1.0.0.0.zip)
2. Add reference your Visual Studio project or other compiler

## Usage

```csharp
// Using
using applog;

// Code
LogSystem myLogs = new LogSystem();
myLogs.WriteNow("path","my own logs");
```

## Examples
```csharp
// As an example, we want to click on any button to write a log.
private void WriteLogButton_Click(object sender, EventArgs e)
{
  LogSystem myLogs = new LogSystem();
  myLogs.WriteNow(@"C:\Program Files\My Company Folder\My App Folder\Logs\", "Firs Log Writed");
}

// Let's find out if the logs are written when the button is clicked and leave the Time stamp.
private void WriteLogButton_Click(object sender, EventArgs e)
{
  LogSystem myLogs = new LogSystem();
  if (myLogs.WriteNow(@"C:\Program Files\My Company Folder\My App Folder\Logs\", "Write Button Clicked[Time: " + DateTime.Now + "]"))
  {
    MessageBox.Show("Process completed!");
  }
  else
  {
    MessageBox.Show("Process failed!");
  }
}

// Notify the end user in case of any error
private void WriteLogButton_Click(object sender, EventArgs e)
{
  LogSystem myLogs = new LogSystem();
  try
  {
    if (myLogs.WriteNow(@"C:\Program Files\My Company Folder\My App Folder\Logs\", "my own log"))
    {
      MessageBox.Show("Process completed!");
    }
    else
    {
      MessageBox.Show("Process failed!");
    }
  }
  catch (Exception ex)
  {
    MessageBox.Show("Error:" + ex.Message);
  }
}
```

## Latest version
1.0.0.0 - Current usage rights are stated below.

## License
It can be used for commercial purposes without any restrictions and attribution.
