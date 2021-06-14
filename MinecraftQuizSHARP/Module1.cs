using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftQuizSHARP
{
    class Module1
    {

        public static int _pontos_craft;
        public static int pontos_craft
        {
            get { return _pontos_craft; }
            set { _pontos_craft = value; }
        }

        public static int _pontos_reds;
        public static int pontos_reds
        {
            get { return _pontos_reds; }
            set { _pontos_reds = value; }
        }
    }
}
