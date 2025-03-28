using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Basic
{
    public static class Day1
    {
        public static void day1()
        {
            //That means Common Language Runtime(CLR) is the execution engine 
            //that handles running applications.It provides services like thread management,
            //garbage collection, type safety, exception handling, and more.

            //When we compile any .NET application, 
            //it will generate an assembly with the extension of either a .DLL or an.EXE.
            //An assembly consists of two things i.e.Manifest and Intermediate language.

            //C# Code  --->  [CTS & CLS Applied]  --->  IL Code (MSIL)  --->  [JIT Compilation]  --->  Native Code.
            //Your C# code is compiled by the C# Compiler (CSC) into Microsoft Intermediate Language (MSIL or IL).
            //During this phase, the Common Type System(CTS) and Common Language Specification(CLS) are applied.
            //The generated MSIL is platform - independent.
            //MSIL(IL Code) → Native Machine Code(JIT Compilation)
            //When the program runs, the Just - In - Time(JIT) compiler converts IL code into native machine code.
            //The native code is CPU and OS - specific


            //The codes which run under the complete control of CLR are called Managed Code in .NET Framework.
            //On the other hand, Skype, PowerPoint, and Microsoft Excel do not require .NET Runtime Environment,
            //they run under their own environment.
            //So, in short, the code(EXE, DLL) which does not run under the control of CLR is called Unmanaged Code.
            
            //The EXE is run in its own address space or in its own memory space
        }
    }
}
