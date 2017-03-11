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
            /// 性別
            Console.Write("Gender:");
            pokemons[0].Gender = Console.ReadLine();

            ///輸出
            Console.WriteLine("您剛剛輸入的Pokemon資訊：\n名字：{0}\n編號：{1}\n特性：{2}\n分類：{3}\n身高：{4}\n體重：{5}\n性別：{6}", pokemons[0].Name, pokemons[0].Numero, pokemons[0].Abilities, pokemons[0].Category, pokemons[0].Height, pokemons[0].Weight, pokemons[0].Gender);
            Console.WriteLine("謝謝您的輸入");
        }
    }
}