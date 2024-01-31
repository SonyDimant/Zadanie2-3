﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    sealed class Massive_1 : PapaArray
    {
        private int[] _array;
        private int _size;

        public int[] Array
        {
            get
            {
                return _array;
            }
        }
        public Massive_1(int size, bool t = false)
        {
            _size = size;
            _array = new int[_size];


            if (!t)
            {
                RandomValues();
            }
            else
            {
                IntValues();
            }
        }


        public override void RandomValues()
        {
            Random rnd = new Random();
            for (int i = 0; i < _size; i++)
            {
                _array[i] = rnd.Next(0, 255);
            }
        }


        public override void IntValues()
        {
            Console.WriteLine("Введите элементы: ");
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = int.Parse(Console.ReadLine());
            }
        }


        public override void ShowArray()
        {
            foreach (int i in _array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public override double AverageValue()
        {
            int count_ = _array.Length;
            double summa = 0;
            for (int i = 0; count_ > i; i++)
            {
                summa += _array[i];
            }
            return summa / count_;
        }

    }
}