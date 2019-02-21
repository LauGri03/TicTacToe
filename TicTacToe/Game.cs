using System;
using System.Collections.Generic;
using Android.Graphics;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TicTacToe
{
    public static class Game
    {
        public static string Play(int phase,string tag, string[,] tab)
        {
            string play;

            if (phase % 2 == 0)
                play = "O";
            else
                play = "X";

            FillTab(tag, tab, play);

            return play;
        }

        private static void FillTab(string tag, string[ , ] tab, string character)
        {
            tab[Convert.ToInt32(tag.Substring(0, 1)), Convert.ToInt32(tag.Substring(1, 1))] = character;
        }
       

        public static string Winner(int phase) {

            string winner;

            
            if (phase % 2 == 0)
                winner = "Joueur 2";
            else
                winner = "Joueur 1";

            return winner;

        }

        public static bool Tie(string[ , ] GameTab)
        {
            bool tie;
            string ok = "";

            for(int i = 0; i <= 2; i++)
            {
                for(int y = 0; y <= 2; y++)
                {
                    ok = ok + GameTab[i, y];
                }
            }

            if (ok.Length == 9 && !Win(GameTab))
                tie = true;
            else
                tie = false;

            return tie;
        }

        public static string GetCharacter(int phase)
        {

            string carac;


            if (phase % 2 == 0)
                carac = "O";
            else
                carac = "X";

            return carac;

        }

        public static Color GetColor(string Character)
        {
            Color color;

            if (Character == "X")
                color = Color.Red;
            else
                color = Color.Blue;

            return color;
        }

        public static bool Win(string[ , ] GameTab)
        {
            bool win;

            string line1 = GameTab[0, 0] + GameTab[0, 1] + GameTab[0, 2];
            string line2 = GameTab[1, 0] + GameTab[1, 1] + GameTab[1, 2];
            string line3 = GameTab[2, 0] + GameTab[2, 1] + GameTab[2, 2];

            string column1 = GameTab[0, 0] + GameTab[1, 0] + GameTab[2, 0];
            string column2 = GameTab[0, 1] + GameTab[1, 1] + GameTab[2, 1];
            string column3 = GameTab[0, 2] + GameTab[1, 2] + GameTab[2, 2];

            string cross1 = GameTab[0, 0] + GameTab[1, 1] + GameTab[2, 2];
            string cross2 = GameTab[0, 2] + GameTab[1, 1] + GameTab[2, 0];

            if ((line1 == "XXX") || (line2 == "XXX") || (line3 == "XXX") || (column1 == "XXX") || (column2 == "XXX") || (column3 == "XXX") || (cross1 == "XXX") || (cross2 == "XXX"))
                win = true;
            else if ((line1 == "OOO") || (line2 == "OOO") || (line3 == "OOO") || (column1 == "OOO") || (column2 == "OOO") || (column3 == "OOO") || (cross1 == "OOO") || (cross2 == "OOO"))
                win = true;
            else
                win = false;


            return win;
        }

        
    }
}