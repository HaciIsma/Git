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
            string commit = "first commit";
            commit = "\"" + commit + "\"";
            string remoteControl = "https://github.com/HaciIsma/Git.git;git";
            string commants = $@"cd ..; cd ..;
                                 git init;
                                 git add .;
                                 git commit -m {commit}; 
                                 git remote add origin {remoteControl}; 
                                 git push -u origin master;
                                 pause;";

            process.StartInfo = new ProcessStartInfo(destination, commants);
            process.Start();
        }
    }
}
