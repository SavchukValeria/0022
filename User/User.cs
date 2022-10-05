namespace _4_exercise
{
    class User
    {
        private string login = "LeraSavchuk";
        private string name = "Lera";
        private string surname = "Savchukk";
        private int age = 18;
        private const string date = "05.10.2022";

        public void Vivod()
        {
            Console.WriteLine($"Login: {login};\nName: {name};\nSurname: {surname};\nAge: {age};\nDate: {date};");
        }
    }
}