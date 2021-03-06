using System;
using System.Diagnostics;

namespace HallmarkCSharp
{
    /*
     * To use subject class correctly please use debugger in class which creates instance of Subject
     * You probably should see additional info in debugger intellisense 
     */
    [DebuggerTypeProxy(typeof(DebuggerMemoryAttribute))]
    [DebuggerDisplay("ID = {SubjectId}, Description {SubjectDescription}")]
    public class Subject
    {
        
        [Custom("SubjectId property", ConsoleColor.Yellow)]
        public string SubjectId => new Random().Next().ToString();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SubjectDescription =>
            "This object is created to describe any kind of object for testing purpose on attributes";

        [Custom("GetSubjectId method", ConsoleColor.Yellow)]
        void GetSubjectId()
        {
            
        }
    }
}