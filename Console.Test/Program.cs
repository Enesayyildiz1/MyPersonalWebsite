using Business.Concretes;
using DataAccess.Concretes;
using System;

namespace Consolee.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AboutManager _aboutManager = new AboutManager(new AboutDal());


            var list = _aboutManager.GetAll().Data;
            Console.WriteLine(list[0].ShortAbout); 

        }
    }
}
