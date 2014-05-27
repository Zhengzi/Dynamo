using System;
using System.Diagnostics;
using Dynamo;
using Dynamo.Controls;
using Dynamo.Core;
using Dynamo.Utilities;

namespace DynamoSandbox
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                // Running Dynamo sandbox with a command file:
                // DynamoSandbox.exe /c "C:\file path\file.xml"
                // 

                switch (args.Length)
                {
                    case 0:
                        RunDynamo();
                        break;
                    case 1:
                        string filePath = args[0];
                        if (System.IO.File.Exists(filePath))
                            RunDynamoWithFile(filePath);
                        else
                            RunDynamo();
                        break;
                    case 2:
                        string arg = args[0];
                        string commandFilePath = args[1];
                        if ((arg[0] == '/') && (arg[1] == 'c' || (arg[1] == 'C')))
                        {
                            if (System.IO.File.Exists(commandFilePath))
                                RunDynamoWithCommand(commandFilePath);
                            else
                                RunDynamo();
                        }
                        else
                            RunDynamo();
                        break;
                    default:
                        RunDynamo();
                        break;
                }
            }
            catch (Exception e)
            {
#if DEBUG

                // Display the recorded command XML when the crash happens, so that it maybe saved and re-run later
                dynSettings.Controller.DynamoViewModel.SaveRecordedCommand.Execute(null);

#endif

                try
                {
                    dynSettings.Controller.IsCrashing = true;
                    // Show the unhandled exception dialog so user can copy the 
                    // crash details and report the crash if she chooses to.
                    dynSettings.Controller.OnRequestsCrashPrompt(null,
                        new CrashPromptArgs(e.Message + "\n\n" + e.StackTrace));

                    // Give user a chance to save (but does not allow cancellation)
                    bool allowCancellation = false;
                    dynSettings.Controller.DynamoViewModel.Exit(allowCancellation);
                }
                catch
                {
                }

                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.StackTrace);
            }
            finally
            {
                ((DynamoLogger) dynSettings.DynamoLogger).Dispose();
            }
        }

        private static void RunDynamo()
        {
            DynamoView.MakeSandboxAndRun(string.Empty);
        }

        private static void RunDynamoWithFile(string dynamoFile)
        {
        }

        private static void RunDynamoWithCommand(string commandFilePath)
        {
            DynamoView.MakeSandboxAndRun(commandFilePath);
        }
    }
}
