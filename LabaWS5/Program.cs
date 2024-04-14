using LabaWS5;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal horse = new Horse();
        horse.makeNoise(horse.Sleep(false));
        new Cat("рыбов", "комната", 1000).Eat();
        Dog sobaka = new Dog("кусок мяса", "дом попа", false);
        sobaka.makeNoise(sobaka.Sleep(true));
        sobaka.Eat();
        new Veterinar().treatAnimal(sobaka);
    }
}