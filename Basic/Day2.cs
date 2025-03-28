using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace Basic
{
    public static class Day2
    {
        public static void appdomain()
        {

            //In this there is risk of accessing the drive
            //ThirdParty Obj3 = new ThirdParty();


            //appdomain is
            //A runtime execution environment for the application.
            //Created automatically by the CLR when the app starts.

            //static void Main() is
            //The entry point method where execution starts.
            //Defined by the programmer in the main class.

            //The default AppDomain is created before Main() runs, and Main() executes inside this AppDomain.
            //Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);



            //Step1 create permissions
            //this for permission 
            //Step1: Create Permission object
            var permission = new PermissionSet(PermissionState.None);
            //Permission for the code to run. 
            //Execution: Without this permission, Managed Code will not be Executed.
            permission.AddPermission(
                new SecurityPermission(SecurityPermissionFlag.Execution)
                );
            //Set No Access to C Drive, 
            //NoAccess: No access to a file or directory.
            permission.AddPermission(
               new FileIOPermission(FileIOPermissionAccess.NoAccess, @"C:\")
               );


            //Step2: Create setup for App Domain
            var setUp = new AppDomainSetup
            {
                //CurrentDomain: Gets the current application domain
                //SetupInformation: Gets the application domain configuration information
                //ApplicationBase: Gets or sets the name of the directory containing the application.
                ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase
            };


            //here is to create custom domain
            //Step1:
            //Create custom App Domain
            //CreateDomain: Creates a new application domain with the specified name.
            AppDomain customDomain = AppDomain.CreateDomain("customDomain", null, setUp, permission);

            //But irrespective of the exception in the Custom App Domain, 
            //if you want to execute the Default App Domain, then you need to put the 
            //logic of the Custom App Domain inside the try-catch block as shown in the below code.

            //try
            //{
            //Step2:
            //Get the Type of ThirdParty using the typeof method by passing the ThirdParty class name
            Type thirdParty = typeof(ThirdParty);

            //Step3:
            //Create an object of ThirdParty using the customDomain i.e. load the ThirdParty
            //To Create an Object, we need to call the CreateInstanceAndUnwrap method of customDomain object
            customDomain.CreateInstanceAndUnwrap(
                                  //Gets the display name of the assembly.
                                  thirdParty.Assembly.FullName,
                                  //Gets the fully qualified name of the type, including its namespace 
                                  //but not its assembly.
                                  thirdParty.FullName);
            //}
            //catch (Exception Ex)
            //{
            //    Console.WriteLine($"Exception Occurred: {Ex.Message}");
            //Step4:
            //Unload the Custom App Domain
            AppDomain.Unload(customDomain);
            //}

            //this is the execution or default appDomain
            Console.WriteLine("Hello try catch");
        }
    }

    [Serializable]
    public class ThirdParty
    {
        public ThirdParty()
        {
            Console.WriteLine("Third Party DLL Loaded");
            System.IO.File.Create(@"C:\Users\bhavya.soni\OneDrive - InTimeTec Visionsoft Pvt. Ltd.,\Desktop\xyz.txt");
        }
        ~ThirdParty()
        {
            Console.WriteLine("Third Party DLL Unloaded");
        }
    }
}

//In.NET Framework Base Class Library, we have several assemblies. 
//All the .NET Framework assemblies are installed in a special location called GAC (Global Assembly Cache).