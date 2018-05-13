//for working with excel we used information from
//http://csharp.net-informations.com/excel/csharp-create-excel.htm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace TFT
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static ALog aLogger = new ALog();
        static bool excelAvailable = false;
        static void Main(string[] args)
        {
            RunTFT();
        }

        private static void RunTFT()
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp != null)
            {
                excelAvailable = true;
            }
            IPlayer daniel = new DanielPlayer();
            IPlayer luana = new LuanaPlayer();
            IPlayer andrei = new AndreiPlayer();
            IPlayer random = new RandomPlayer();
            IPlayer oana = new OanaPlayer();
            IPlayer oana2 = new OanaPlayer2();
            IPlayer dana = new DanaPlayer();
            IPlayer dana2 = new DanaSecondPlayer();
            IPlayer random2 = new RandomPlayer2();
            IPlayer tftnice = new TFTPlayernice();
            IPlayer meanTFT = new TFTPlayerMean();
            IPlayer andreiMF = new AndreiMFPlayer();
            IPlayer error = new PlayerWithError();
            IPlayer cristi = new CristiPlayer();
            IPlayer cristi2 = new CristiSecondPlayer();
            IPlayer player2 = new Player2();
            IPlayer boss = new PlayLikeABoss();

            var game = new Game(cristi2, boss);
            var var = boss.GetType().ToString();
            List<IPlayer> players = new List<TFT.IPlayer>();
            players.Add(daniel);
            players.Add(luana);
            players.Add(andrei);
            players.Add(oana);
            players.Add(dana);
            players.Add(dana2);
            players.Add(random2);
            players.Add(tftnice);
            players.Add(meanTFT);
            players.Add(andreiMF);
            players.Add(error);
            players.Add(cristi);
            players.Add(cristi2);
            players.Add(player2);
            players.Add(boss);
            if (excelAvailable)
            {
                _Workbook xlWorkBook = xlApp.Workbooks.Add();
                _Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Cells[1, 1] = "ID";
                xlWorkSheet.Cells[1, 2] = "Name";
                xlWorkSheet.Cells[2, 1] = "1";
                xlWorkSheet.Cells[2, 2] = "One";
                xlWorkSheet.Cells[3, 1] = "2";
                xlWorkSheet.Cells[3, 2] = "Two";
                xlWorkBook.SaveAs("your-file-name.xls");
            }
            //var game = new Game(meanTFT, andreiMF);
            //var game = new Game(dana, andrei);
            //var game = new Game(dana, random);
            //var game = new Game(dana2, random2);

            //var game = new Game(luana, andrei);
            //var game = new Game(random, andrei);
            //var game = new Game(random, luana);
            //var game = new Game(random2, luana);
            //var game = new Game(random2, random);
            //var game = new Game(random2, andrei);
            //var game = new Game(tftnice, luana);
            //var game = new Game(tftnice, random);
            //var game = new Game(tftnice, random2);
            //var game = new Game(tftnice, andrei);
            //var game = new Game(oana, andrei);
            //var game = new Game(oana, luana);
            //var game = new Game(oana, random);
            //var game = new Game(oana, random2);
            //var game = new Game(oana, tftnice);
            try
            {
                game.RunGame();
            }
            catch (Exception e)
            {
                aLogger.Log("error message: " + e.Message + ";source: " + e.Source);
                logger.Error("error message: " + e.Message + ";source: " + e.Source);
                Console.WriteLine("Ai gresit jocu' baiatu meu!");
            }
            Console.ReadLine();
        }
    }
}
