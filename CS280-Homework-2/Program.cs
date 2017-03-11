using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Homework_1._2;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon[] pokemons = new Pokemon[3];
            pokemons[0] = new Pokemon();
            Console.WriteLine("請輸入一隻Pokemon");
            /// 名字
            Console.Write("Name:");
            pokemons[0].Name = Console.ReadLine();
            /// 編號
            Console.Write("NationalNo:");
            try
            {
                pokemons[0].Numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("編號應為數字");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            /// 特性
            Console.Write("Abilities:");
            pokemons[0].Abilities = Console.ReadLine();
            /// 分類
            Console.Write("Category:");
            pokemons[0].Category = Console.ReadLine();
            /// 身高
            Console.Write("Height:");
            try
            {
                pokemons[0].Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("編號應為數字");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            /// 體重
            Console.Write("Weight:");
            try
            {
                pokemons[0].Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("編號應為數字");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.WriteLine("謝謝您的輸入");
        }
    }
}