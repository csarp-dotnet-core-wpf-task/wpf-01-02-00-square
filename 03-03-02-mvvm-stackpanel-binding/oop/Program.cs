using System;
using _02_02_exception_debug.model;

// S2 .12 A hibát loggolhatjuk a consolra.
using System.Diagnostics;


namespace _02_02_exception_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            // S2.01 Negatív oldalú négyzetet is példányosítani lehet!
            // Square mySquare = new Square(-2);
            // Console.WriteLine(mySquare);
            // Console.WriteLine("Kerülete: "+mySquare.District+" méter.");
            // Console.WriteLine("Területe: "+mySquare.Area+" négyzetméter.");

            // S2.06 Ha negatív oldalú négyzetet példaányosítunk akkor elkapjuk a kivételt.
            //       A kivételkezelés egy programozási mechanizmus, melynek célja a program futását szándékosan
            //       vagy nem szándékolt módon megszakító esemény (hiba) vagy utasítás kezelése.
            //       https://hu.wikipedia.org/wiki/Kivételkezelés
            //       Kivételkezelő blokk
            //       A try blokk tartalmazza a kivételkezeléssel védett utasításokat.
            //       https://csharptutorial.hu/docs/hellovilag-hellocsharp/4-vezerlesi-szerkezetek-es-blokkok/try-catch/
            int wrongSide = -2;
            try
            {
                Square myBadSquare = new Square(wrongSide);
            }
            // S2.07 Elkapjuk a saját kivételünket
            //       Ha a program végrehajtása közben valami hiba lép fel,
            //       akkor a try blokkhoz rendelt catch hibakezelőbe akkor kerül a vezérlés,
            //       ha a catch feltételben meghatározott típusú hiba lép fel.
            //       Ha nem kapjuk el a kivételt, a program végrehajtása megszakad.
            catch (SqueraSideCannotBeNagativOrZero negativeOrZeroException)
            {
                // S2.08 A kivétel szövegét megjeleníthetjük a képernyőn.
                Console.WriteLine(negativeOrZeroException.Message);
                // S2.12 A hibát loggolhatjuk a consolra.
                //       Kell hozzáa a using System.Diagnostics;
                Debug.WriteLine(negativeOrZeroException.Message);
            }
            // S2.09 catch ágból lehet több.
            //       Elkapunk bármilyen más kivételt.
            catch (Exception anyException)
            {
                // S2.10 A hibát loggolhatjuk a consolra.
                Console.WriteLine(anyException.Message);
                // S2.12 A hibát loggolhatjuk a consolra.
                Debug.WriteLine(anyException.Message);
            }
            // S2.11 A try blokk után állhat egy finally blokk is.
            //       A finally blokk opcionális része a kivételkezelésnek.
            //       A benne elhelyezett kód akkor is lefut, ha a vezérlés átkerül a catch blokkba.
            //       Leginkább olyan esetekben van értelme a használatának,
            //       ha kivétel esetén is fel szeretnénk szabadítani az erőforrást, amit használunk.
            finally
            { }
        }
    }
}
