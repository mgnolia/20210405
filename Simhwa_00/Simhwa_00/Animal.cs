using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhwa_00
{
    abstract class Animal : iRunnable, iFight
    {
        public void fight()
        {
            System.Windows.Forms.MessageBox.Show("퍽퍽");
        }

        public void Run()
        {
            System.Windows.Forms.MessageBox.Show("슉슉달린다");
        }
    }
}
