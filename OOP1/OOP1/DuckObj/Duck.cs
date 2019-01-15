using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
public abstract class Duck
{
    protected FlyBehavior flyBehavior;
    protected QuackBehavior quackBehavior;

    public Duck()
    {

    }

    public abstract void display();

    public void performFly()
    {
        flyBehavior.Fly();
    }

    public void perfomQuack()
    {
        quackBehavior.Quack();
    }

    public void setFlyBehavior(FlyBehavior fb)
    {
        flyBehavior = fb;
    }

    public void setQuackBehavior(QuackBehavior qb)
    {
        quackBehavior = qb;
    }

    public void swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}
}
