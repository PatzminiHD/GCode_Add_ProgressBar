using System;
using System.IO;
using static System.Console;

namespace GCode_Add_ProgressBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sFilePath;
            try
            {
                sFilePath = args[0];
            }
            catch
            {
                WriteLine("Please Input the Filepath:");
                sFilePath = ReadLine();
            }
            if(File.Exists(sFilePath))
            {
                string[] saFile = File.ReadAllLines(sFilePath);
                int iPercent;
                for (int i = 0; i <= 100; i++)
                {
                    
                }
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"The specified File \"{sFilePath}\" does not exist.");
                ResetColor();
            }
        }
        public static void AddNewLineToArray(int iYPos, ref string[] saFile, string sStringToAdd)
        {
            string[] saOut = new string[saFile.Length + 1];
            for (int i = 0; i < iYPos; i++)
            {
                saOut[i] = saFile[i];
            }
            saOut[iYPos] = saFile[iYPos];
            saOut[iYPos + 1] = sStringToAdd;

            for (int i = iYPos + 2; i < saOut.Length; i++)
            {
                saOut[i] = saFile[i - 1];
            }
            saFile = saOut;
        }
    }
}
