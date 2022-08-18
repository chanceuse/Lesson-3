using System;

namespace Lesson3
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Текст");
            int integerVal = 32;
            float numF = 32.35f;
            double numD = 32.23;
            char sim = 'e';
            string str = "Карл у Клары урал кораллы";
            bool check =  true;
            integerVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введенное значение " + integerVal);
            integerVal = 48;
            Console.WriteLine("Новое значение " + integerVal);
            int a = 3;
            int b = 8;
            int c;
            c = a + b;
            Console.WriteLine("Сумма: " + c);
            c = a - b;
            Console.WriteLine("Разность: " + c);
            c = a * b;
            Console.WriteLine("Произведение: " + c);
            c = a / b;
            Console.WriteLine("Деление: " + c);
            c++;
            Console.WriteLine("Инкремент: " + c);
            c--;
            Console.WriteLine(value: "Декремент: " + c);
            if (a>b){
                Console.WriteLine(value: "Это правда!");
            }
            else if (a==b){
                Console.WriteLine(value: "Они равны!" );
            }
            else {
                Console.WriteLine(value: "Вся наша жизнь - ложь!" );
            }
            switch (a){
                case 1:
                b = 45;
                break;
                case 76:
                b = 2;
                Console.WriteLine(value: "Hi!" );
                break;                
                case 56:
                b = 65;
                break;
            }
            Console.WriteLine(value: "Начинаем расчет!" );
            for (int i = 0; i < 10; i++){
                Console.WriteLine(value: "Ученик " + i + "й" );
            }
            Console.WriteLine(value: "Расчет окончен!" );
            int j = 0;
            while (j<10){
                Console.WriteLine(j);
                j++;
            }
            string[] myClass =  new string[3];
            myClass[0] = "Vasya";
            myClass[1] = "Petya";
            myClass[2] = "Sweta";
            for (int i = 0; i < 3; i++){
                Console.WriteLine(myClass[i]);
            }
            List<int> nums = new List<int>();
            nums.Add(73);
            nums.Add(49);
            sayHello();
            Console.WriteLine(summ(a, b));
            Cat barsik = new Cat("Barsik");
            barsik.sayMew();
            Console.WriteLine(barsik.getName());
            Cat tosha = new Cat("Tosha");
            tosha.sayMew();
            Console.WriteLine(tosha.getName());
        }
        public static void sayHello(){
            Console.WriteLine("Hello!");
        }
        public static int summ(int a, int b){
            return a + b;
        }
    }
    public class Cat{
        private string name = "NoName";
        public Cat (string name){
            this.name = name;
        }
        public void sayMew(){
            Console.WriteLine(name + ": Mew!");
        }
        public string getName(){
            return name;
        }
    }
}