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
            //string commit = "first commit";
            //commit = "\"" + commit + "\"";
            string remoteControl = @"https://github.com/HaciIsma/Git.git;git";
            string cd = $"cd ..; cd ..;";
            string init = "git init;";
            string commit = "git commit -m \'first commit\'; ";
            string add = "git add . ;";
            string remote = "git remote add origin https://github.com/HaciIsma/Git.git;";
            process.StartInfo = new ProcessStartInfo(destination,cd+init+add+commit+remote+"pause");
            process.Start();
        }
    }
}
