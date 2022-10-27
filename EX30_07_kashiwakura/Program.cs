using System;

namespace EX30
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(10, 19, 100, DateTime.Today, "KS", 50, 150, 30, 50);
            Console.WriteLine($"名前{student.Name} 年齢{student.Age} 誕生日{student.Birthday.Date} 今日は誕生日か({student.GetTodayBirthDay()}) 学籍番号{student.StudentNumber}");
            Worker worker = new Worker("DigitalArtsCompany", 25, 100, DateTime.Today, "SS", 50, 100, 30, 50);
            Console.WriteLine($"名前{worker.Name} 年齢{worker.Age} 誕生日{worker.Birthday.Date} 会社名{worker.CompanyName}");
            Fish fish = new Fish(true, DateTime.Today, "スズキ", 10, 50, 10, 10);
            Console.WriteLine($"名前{fish.Name} 重さ{fish.Width} 食べられるか({fish.Eatable})");
            Refrigerator refrigerator = new Refrigerator(150, 300, 80, 200, 100, "冷蔵庫", 70, 190, 90, 30);
            Console.WriteLine($"名前{refrigerator.Name} 重さ{refrigerator.Weight} 容量{refrigerator.Capacity}L");
            Insect insent = new Insect(true, DateTime.Today, "カメムシ", 2, 2, 1, 0.5f);
            Console.WriteLine($"名前{insent.Name} 重さ{insent.Flyable}");
            Car car = new Car(25, "カローラクロス", 182, 162, 449, 1330);
            Console.WriteLine($"名前{car.Name} 燃費{car.FuelConsumption}");
            Cat cat = new Cat("スコティッシュフォールド", DateTime.Today, "猫", 30, 30, 60, 20);
            Console.WriteLine($"名前{cat.Name} 猫種{cat.CatType}");
            Dog dog = new Dog("秋田県", DateTime.Today, "犬", 40,60, 100, 40);
            Console.WriteLine($"名前{dog.Name} 犬種{dog.DogType}");



        }
    }
}
