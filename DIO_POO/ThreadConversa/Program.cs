using System.Collections.Generic;
using System;
using System.IO;
using System.Globalization;
using System.Drawing;

namespace ThreadConversa
{
    public class Principal
    {
        static void Main(string[] args)
        {
            var thread = new Thread();
            using(var reader = new StreamReader("texto.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    Mensagem msg = new Texto(values[0], values[1], DateTime.Parse(values[2]), new Identidade(values[3]));
                    thread.AdicionaMensagem(msg);
                }

            }
            Mensagem img = new Imagem(CreateByteArray(2));
            //thread.AdicionaMensagem(img);

            Console.WriteLine();
            Console.WriteLine(thread.MostraThread());
            thread.RemoveMensagem("1");
            Console.WriteLine();
            Console.WriteLine(thread.MostraThread());
            
        }

        public static byte[] CreateByteArray(int length)
        {
            var arr = new byte[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0x20;
            }
            return arr;
        }
    }
}
