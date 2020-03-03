namespace P10Crossroads
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            var greenLightDur = int.Parse(Console.ReadLine());
            var freeWindowDur = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();
            var queueOfCars = new Queue<string>();
            var carCounter = 0;
            while (input != "END")
            {
                if (input != "green")
                {
                    queueOfCars.Enqueue(input);
                }
                else if (queueOfCars.Count > 0)
                {
                    var currentCar = queueOfCars.Dequeue();
                    var currentCarLetters = new Queue<char>(currentCar.ToCharArray());
                    var currentLetter = currentCarLetters.Dequeue();

                    var sameCar = true;
                    for (int i = 0; i < greenLightDur; i++)
                    {
                        if (currentCarLetters.Count > 0)
                        {
                            sameCar = true;
                            currentLetter = currentCarLetters.Dequeue();
                        }
                        else if (queueOfCars.Count > 0)
                        {
                            sameCar = false;
                            currentCar = queueOfCars.Dequeue();
                            currentCarLetters = new Queue<char>(currentCar.ToCharArray());
                            currentLetter = currentCarLetters.Dequeue();
                            carCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (sameCar)
                    {
                        var isCarHit = true;
                        for (int i = 0; i < freeWindowDur; i++)
                        {
                            if (currentCarLetters.Count > 0)
                            {
                                currentLetter = currentCarLetters.Dequeue();
                            }
                            else
                            {
                                isCarHit = false;
                                break;
                            }
                        }

                        if (isCarHit)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentLetter}.");
                            return;
                        }
                        carCounter++;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carCounter} total cars passed the crossroads.");

        }
    }
}
