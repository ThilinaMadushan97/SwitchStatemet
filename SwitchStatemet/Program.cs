DisplayMesurement(2.0);
DisplayMesurement(-2.0);
DisplayMesurement(double.NaN);
DisplayMesurement(5.0);
DisplayMesurement(6.0);


void DisplayMesurement(double value)
{
    switch (value)
    {
        case < 0.0:
            Console.WriteLine($"Your value is low {value}");
            break;

        case > 1.0:
            Console.WriteLine($"Your value is high {value}");
            break;

        case double.NaN:
            Console.WriteLine($"Fail mesurement");
            break;

        default:
            Console.WriteLine($"Your mesurment is {value}");
            break;
    }
}