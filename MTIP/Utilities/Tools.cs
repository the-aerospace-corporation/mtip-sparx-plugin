/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Set of functions used to prompt for XML files, read XML files, and create XML files.
 *              Also includes function for creating debug logs
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MTIP.Utilities
{
    class Tools
    {
        private static StreamWriter streamWriter = null;
        private static readonly string LOG_DIRNAME = "MTIPLogs";

        public static string PromptForFile(string dialogTitle)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = dialogTitle;
            DialogResult dialogResult = openFileDialog.ShowDialog();
            string result = null;

            if (dialogResult == DialogResult.OK)
            {
                result = openFileDialog.FileName;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static string[] PromptForFiles(string dialogTitle)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = dialogTitle;
            openFileDialog.Multiselect = true;
            DialogResult dialogResult = openFileDialog.ShowDialog();
            string[] result = null;

            if (dialogResult == DialogResult.OK)
            {
                result = openFileDialog.FileNames;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static string PromptForDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            string result = null;
            if (dialogResult == DialogResult.OK)
            {
                result = folderBrowserDialog.SelectedPath;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static void Log(string message)
        {

            //string logDirPath = Path.Combine(Path.GetTempPath(), LOG_DIRNAME);            
            string logDirPath = Path.Combine("C:/users/klm31771/desktop/", LOG_DIRNAME);

            //string logDirPath = Path.Combine("./", LOG_DIRNAME);            

            if (!Directory.Exists(logDirPath))
            {
                Directory.CreateDirectory(logDirPath);
            }

            if (streamWriter == null)
            {
                string dateString = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");

                string logFname = String.Format("LOG_{0}.txt", dateString);

                string logfilePath = Path.Combine(logDirPath, logFname);

                streamWriter = new StreamWriter(logfilePath);
                streamWriter.WriteLine("*** LOGGER INITIALIZED ***");
                streamWriter.WriteLine("Starting at: " + DateTime.Now.ToString());
            }

            //streamWriter.WriteLine(String.Format("{0} :: {1}", DateTime.Now.ToString(),  message));
            streamWriter.WriteLine(message);
            streamWriter.Flush();
        }
        public static void WriteToFile(string filename, string text)
        {
            StreamWriter fileWriter = new StreamWriter(filename);
        }

        public static void WriteDebugToFile(string filename, string text)
        {
            string filepath = Path.Combine(@"C:\path\to\directory", filename);
            StreamWriter fileWriter = new StreamWriter(filepath);

            fileWriter.Write(text);

            fileWriter.Close();
        }
        public static bool PromptUser(string info, string question, MessageBoxButtons buttons)
        {
            DialogResult dialogResult = MessageBox.Show(info, question, buttons);
            bool isYes = dialogResult.Equals(DialogResult.Yes);
            return isYes;
        }
        public static XmlDocument ReadDocument(string filename)
        {
            try
            {

                Regex rx = new Regex("[\x00-\x1F]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                StreamReader streamReader = new StreamReader(filename);
                StringBuilder stringBuilder = new StringBuilder();

                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string modifiedLine = rx.Replace(line, string.Empty);

                    stringBuilder.Append(modifiedLine);
                }

                string fixedString = stringBuilder.ToString();

                XmlDocument document = new XmlDocument();
                document.LoadXml(fixedString);

                return document;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(" Error reading file: {0} \nMessage: {1} \nStackTrace: {2}", filename, ex.Message, ex.StackTrace));
                return null;
            }

        }
    }
}
