﻿using System;
using System.Diagnostics;

namespace ConsoleApp11
{
    static class Git
    {
        public static void Go()
        {
            Process process = new Process();
            string destination = "Powershell.exe";
            string commit = default;
            Console.Write("Enter commit: ");
            commit = Console.ReadLine();
            commit = "\'" + commit + "\'";
            string remoteControl = "https://github.com/HaciIsma/Git.git";
            string command = $"cd..; cd..; git init;git add .; git commit -m {commit};git remote add origin {remoteControl} ;git push -u origin master;pause";
            process.StartInfo = new ProcessStartInfo(destination, command);
            process.Start();
        }
    }
}
