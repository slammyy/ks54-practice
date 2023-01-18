namespace Program2
{ 
    delegate int Operation(char symbol, string line); 
 
    class Program 
    { 
        static void Main() 
        { 
            char symbol = 'o'; 
            string line = "hello world"; 
            Operation del = Entrance; 
            int result = del(symbol, line); 
            Console.WriteLine(result); 
 
            del = Index; 
            result = del(symbol, line); 
            Console.WriteLine(result); 
            Console.ReadKey(); 
        } 
 
        private static int Entrance(char symbol, string line) 
        { 
            int num = 0; 
            for (int i = 0; i < line.Length; i++) 
            { 
                if (symbol == line[i]) 
                    num++; 
            } 
            if (num == 0) 
                return -1; 
            return num; 
        } 
        private static int Index(char symbol, string line) 
        { 
            return line.IndexOf(symbol); 
        } 
    } 
}
