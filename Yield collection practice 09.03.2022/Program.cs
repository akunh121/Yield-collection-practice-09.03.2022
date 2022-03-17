using System.Collections;
using System.Collections.Generic;

//
class Program
{
    public static void Main(String[] args)
    {

        Agency a1 = new Agency();
        a1.Cars = new Car[]{
        new Car(){ ModelYear = 2001 , Maker = "Subaro"},
        new Car(){ ModelYear = 2021 , Maker = "Toyota"},
        new Car(){ ModelYear = 2013 , Maker = "Subaro"},
        new Car(){ ModelYear = 2004 , Maker = "Fiat"},
        new Car(){ ModelYear = 2021 , Maker = "Fiat"},
        new Car(){ ModelYear = 2015 , Maker = "Subaro"}
};
        //
        System.Console.WriteLine("All cars in the agency:");
        foreach (var car in a1)
            System.Console.WriteLine(car);
        System.Console.WriteLine("All cars in the agency from 2021:");
        foreach (var car in a1.GetCars(2021))
            System.Console.WriteLine(car);
        System.Console.WriteLine("All cars in the agency of Fiat:");
        foreach (var car in a1.GetCars("Fiat"))
            System.Console.WriteLine(car);
    }

    public class Agency
    {
        public Car[]? Cars { get; set; }
        //public List<Car>? cars;


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                yield return Cars[i].ModelYear + "," + Cars[i].Maker;
            }

        }
        public IEnumerable GetCars(int year)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].ModelYear == 2021)
                {
                    yield return Cars[i].ModelYear + "," + Cars[i].Maker;
                }

            }

        }
        public IEnumerable GetCars(string marker)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Maker == marker)
                {
                    yield return Cars[i].ModelYear + "," + Cars[i].Maker;
                }

            }

        }

    }
}
public class Car
{
    public int ModelYear { get; set; }
    public string Maker { get; set; }
    //public Car(int ModelYear, string Maker)
    //{
    //    this.ModelYear = ModelYear;
    //    this.Maker = Maker;
    //}

    //public Car()
    //{

    //}
}