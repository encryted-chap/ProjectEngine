using System;
// main namespace for this game engine
namespace Engine {
    public class Debug {
        public static void LogSuccess(string message) {
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("success ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("] " + message + "\n");
        }
    }
}