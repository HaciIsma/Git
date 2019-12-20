using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            string destination = "Powershell.exe";
            string commit = "4";
            commit = "\'" + commit + "\'";
            string remoteControl = "https://github.com/HaciIsma/Git.git";
            string command = $"cd..; cd..; git init; git commit -m {commit};git add .;git remote add origin {remoteControl} ;git push -u origin master;pause";
            process.StartInfo = new ProcessStartInfo(destination, command);
            process.Start();
        }
    }
}
