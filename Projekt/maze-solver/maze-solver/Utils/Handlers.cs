using System;
using System.Drawing;
using System.Windows.Forms;
using static maze_solver.Form1;

namespace maze_solver.Utils
{
    public class Handlers
    {
        public static void Handle_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Config.WALL_COLOR) btn.BackColor = Color.Transparent;
            else btn.BackColor = Config.WALL_COLOR;

        }

        public static void Handle_hover(object sender, EventArgs e)
        {
            GameManger.currentHoverBtn = sender as Button;
        }

        public static void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameManger.currentHoverBtn == null) return;

            if (e.KeyCode.ToString() == "S")
            {

                if (GameManger.startBtn != null) GameManger.startBtn.BackColor = Color.Transparent;
                GameManger.currentHoverBtn.BackColor = Config.START_COLOR;
                GameManger.startBtn = GameManger.currentHoverBtn;
            }
            if (e.KeyCode.ToString() == "E")
            {
                if (GameManger.endBtn != null) GameManger.endBtn.BackColor = Color.Transparent;
                GameManger.currentHoverBtn.BackColor = Config.END_COLOR;
                GameManger.endBtn = GameManger.currentHoverBtn;
            }
        }

    }
}
