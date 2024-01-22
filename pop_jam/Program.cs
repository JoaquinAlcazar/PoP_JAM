namespace PP2M03M05
{
    public class provaPractica
    {
        public static void Main(string[] args)
        {
            string passwordInput;

            Console.WriteLine("Introduce contraseña");
            passwordInput = Console.ReadLine();

            Console.WriteLine(passwordChecker(passwordInput) ? "Es correcte" : "No es correcte");
        }

        public static bool passwordChecker(string password)
        {

            char[] invalidChars = { '*', 'ñ', '#', '@', '€', '%', '&', '¡', '!', '?', '¿' };
            char actualLetter;
            char specialTester;
            int charCounter = 0;
            foreach (char c in password)
            {
                actualLetter = c;
                foreach (char c2 in invalidChars)
                {
                    specialTester = c2;
                    if (actualLetter == specialTester)
                    {
                        return false;
                    }
                }
                charCounter++;
            }
            if (charCounter < 5 || charCounter > 12)
            {
                return false;
            }
            return true;
        }
    }
}
