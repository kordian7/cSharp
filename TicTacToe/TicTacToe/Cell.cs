using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Cell
    {
        private Content content;

        public Cell(Content content) {
            this.content = content;
        }

        public Content Cont
        {
            set { content = value; }
            get { return content; }
        }

        public string getContentStr()
        {
            if (content == Content.EMPTY)
                return "   ";
            else
                return " " + content + " ";
        }
    }
}
