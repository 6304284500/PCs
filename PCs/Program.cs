using PCs;

public class Program
{
    public static void Main(string[] args)
    {
        UC1 uC1 = new UC1();
        uC1.one();
        UC2 uC2 = new UC2();
        uC2.two();
        UC3 uC3 = new UC3();
        uC3.three();
        UC4 uC4 = new UC4();
        uC4.four();
        UC5 uC5 = new UC5();
        uC5.five();
        UC6 uC6 = new UC6();
        uC6.switch1();
        UC7 uC7 = new UC7();
        uC7.switch2();
        fact fact = new fact();
        fact.For2();
        sums sums = new sums();
        sums.UC9();
        UC8 uC8 = new UC8();
        uC8.For1();
        Reverse reverse = new Reverse();
        reverse.while1();
        Natural natural = new Natural();
        natural.while2();

    }
}