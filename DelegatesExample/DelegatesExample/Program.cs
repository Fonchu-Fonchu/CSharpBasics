/***
 * 
 * Delegates represents reference types to methods with particular
 * parameter list and return type.
 * 
 * Delegates provide the posibilty of passing functions to variables
 * and as parameters to other functions.
 * 
 * 
 * They are similar to function pointer in other programming languages.
 * They are object oriented.
 * 
 * ***/

delegate double Function(double x);
class Multiplier
{
    double _factor;
    public Multiplier(double factor) => _factor = factor;
    public double Multiply(double x) => x * _factor;
}
class DelegateExample
{
    static double[] Apply(double[] a, Function f)
    {
        var result = new double[a.Length];
        for (int i = 0; i < a.Length; i++) result[i] = f(a[i]);
        return result;
    }
    public static void Main()
    {
        double[] a = { 0.0, 0.5, 1.0 };
        double[] squares = Apply(a, (x) => x * x);
        double[] sines = Apply(a, Math.Sin);
        Multiplier m = new(2.0);
        double[] doubles = Apply(a, m.Multiply);
    }
}