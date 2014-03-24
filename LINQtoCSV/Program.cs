using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using KabuUriKai;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var plines = File.ReadAllLines(@"C:\Users\tomohiko\Documents\01_kabu\tool\data\2014-03-14.dat", Encoding.GetEncoding("Shift_JIS"));
            //var prefs =
            //    from pline in plines.Skip(2)
            //        let p = pline.Split(',')
            //    select new JudgeUrikaiData( p[0], p[1] );

            //foreach (var pref in prefs)
            //{
            //    Console.WriteLine("PrefCode = {0}, PrefName = {1}", pref.Code, pref.Meigara);
            //}
            //Console.ReadLine();

            var kabuUriKai = new JudgeUrikai();
            kabuUriKai.CreateJudgeFile();

            Console.ReadLine();
        }
    }
}
