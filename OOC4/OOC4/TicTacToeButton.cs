using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOC4
{
    class TicTacToeButton : Button
    {
        public static int Btn_Size = 75;
        public TicTacToeButton()
        {
            this.Width = this.Height = Btn_Size;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Text = "*";
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Consolas", 25);
        }
    

    }
}
