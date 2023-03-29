namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Lassie";
            int legs = 8;
            char letter = 'L';
            bool pottyTrained = false;
            double runSpeed = 98.163;
            decimal sleepHours = 9.54m;

            Console.WriteLine($"Meet my dog, {dogName}. It has {legs} legs and a capital {letter} on its collar and dog bowl. " +
                $"Unfortunately, it is {pottyTrained} that it is potty trained. But, it runs at speeds of {runSpeed} miles per hour when it has to go. It sleeps for around {sleepHours} hours per day");
        }
    }
}
