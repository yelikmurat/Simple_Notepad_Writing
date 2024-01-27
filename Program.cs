using System;
using System.Diagnostics;
using System.Threading;
using WindowsInput;

class Program
{
    static void Main()
    {
        // Start Notepad
        Process notepadProcess = Process.Start("notepad.exe");

        Thread.Sleep(2000);

        SendKeysToNotepad("Hi, this is Eli and this is my test project");

        Thread.Sleep(2000);

        // Close Notepad
        notepadProcess.CloseMainWindow();
    }

    static void SendKeysToNotepad(string message)
    {
        var simulator = new InputSimulator();
        simulator.Keyboard.TextEntry(message);
    }
}
