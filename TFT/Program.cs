//for working with excel we used information from
//http://csharp.net-informations.com/excel/csharp-create-excel.htm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
//using Microsoft.Office.Interop.Excel;

namespace TFT
{
    class Program
    {
        #region fields
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static ALog aLogger = new ALog();
        static bool excelAvailable = false;
        static Dictionary<IPlayer, int> scores;
        static int[,] results;
        static List<IPlayer> players;
        #endregion
        static void Main(string[] args)
        {
            RunTFT();
        }

        private static void RunTFT()
        {
            //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //if (xlApp != null)
            //{
            //    excelAvailable = true;
            //}
            IPlayer daniel = new DanielPlayer();
            IPlayer daniel2 = new DanielPlayer2();
            IPlayer luana = new LuanaPlayer();
            IPlayer luana2 = new LuanaSecondPlayer();
            IPlayer andrei = new AndreiPlayer();
            IPlayer andreiMF = new AndreiMFPlayer();
            IPlayer andrei3 = new Andrei3Player();
            IPlayer oana = new OanaPlayer();
            IPlayer oana2 = new OanaPlayer2();
            IPlayer oana3 = new OanaPlayer3();
            IPlayer dana = new DanaPlayer();
            IPlayer dana2 = new DanaSecondPlayer();
            IPlayer random2 = new RandomPlayer2();
            IPlayer tftnice = new TFTPlayernice();
            IPlayer meanTFT = new TFTPlayerMean();
            IPlayer error = new PlayerWithError();
            IPlayer cristi = new CristiPlayer();
            IPlayer cristi2 = new CristiSecondPlayer();
            IPlayer cristi3 = new CristiPlayer3();
            IPlayer player2 = new Player2();
            IPlayer boss = new PlayLikeABoss();
            IPlayer gaby = new CorlyPlayerOne();

            //var game = new Game(cristi2, boss);
            var var = boss.GetType().ToString();
            players = new List<IPlayer>();
            players.Add(daniel); players.Add(daniel2);
            players.Add(luana); players.Add(luana2);
            players.Add(andrei); players.Add(andrei3);
            players.Add(oana); players.Add(oana2); players.Add(oana3);
            players.Add(dana);
            players.Add(dana2);
            //players.Add(random2);
            players.Add(tftnice);
            players.Add(meanTFT);
            players.Add(andreiMF);
            players.Add(error);
            players.Add(cristi);
            players.Add(cristi2); players.Add(cristi3);
            players.Add(player2);
            players.Add(boss);
            players.Add(gaby);
            if (excelAvailable)
            {
                //_Workbook xlWorkBook = xlApp.Workbooks.Add();
                //_Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //xlWorkSheet.Cells[1, 1] = "ID";
                //xlWorkSheet.Cells[1, 2] = "Name";
                //xlWorkSheet.Cells[2, 1] = "1";
                //xlWorkSheet.Cells[2, 2] = "One";
                //xlWorkSheet.Cells[3, 1] = "2";
                //xlWorkSheet.Cells[3, 2] = "Two";
                //xlWorkBook.SaveAs("your-file-name.xls");
            }
            scores = new Dictionary<IPlayer, int>();
            results = new int[players.Count, players.Count];
            try
            {
                for (int i = 0; i < players.Count - 1; i++)
                {
                    for (int j = i + 1; j < players.Count; j++)
                    {
                        var game = new Game(players[i], players[j]);
                        game.RunGame();
                        var latestGameResults = game.Scores;
                        if (scores.ContainsKey(players[i]))
                        {
                            scores[players[i]] += latestGameResults[0];
                        }
                        else
                        {
                            scores.Add(players[i], latestGameResults[0]);
                        }
                        if (scores.ContainsKey(players[j]))
                        {
                            scores[players[j]] += latestGameResults[1];
                        }
                        else
                        {
                            scores.Add(players[j], latestGameResults[1]);
                        }
                        results[i, j] = latestGameResults[0];
                        results[j, i] = latestGameResults[1];
                    }
                }
                cwmatrice();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                aLogger.Log("error message: " + e.Message + ";source: " + e.Source);
                logger.Error("error message: " + e.Message + ";source: " + e.Source);
                Console.WriteLine("Ai gresit jocu' baiatu meu!");
            }
            Console.ReadLine();
        }

        private static void cwmatrice()
        {
            Console.Write("  ");
            for (int i = 0; i < players.Count; i++)
            {
                Console.Write(("P" + i).PadLeft(4, ' '));
            }
            Console.WriteLine();
            for (int i = 0; i < players.Count; i++)
            {
                Console.Write(("P" + i).PadRight(3, ' '));
                for (int j = 0; j < players.Count; j++)
                {
                    Console.Write(results[i, j].ToString().PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
