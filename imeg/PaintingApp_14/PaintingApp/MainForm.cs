using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PenTool p = PenTool.prepare(this);
            p.down();
            p.right();
            p.right();
            p.right();
            p.right();
            p.right();
            p.right();
            p.startLine();
            
            for (int y = 0; y < 5; y++)
            {
                for (int i = 0; i < 1; i++)
                {
                    p.left();
                }
                for (int i = 0; i < 1; i++)
                {
                    p.down();
                }
            }
            for (int i = 0; i < 1; i++)
            {
                p.right();
            }
            for (int i = 0; i < 4; i++)
            {
                p.down();
            }
            for (int i = 0; i < 3; i++)
            {
                p.right();
            }
            for (int i = 0; i < 3; i++)
            {
                p.up();
            }
            for (int i = 0; i < 2; i++)
            {
                p.left();
            }
            for (int i = 0; i < 3; i++)
            {
                p.down();
            }
            for (int i = 0; i < 5; i++)
            {
                p.right();
            }
            for (int i = 0; i < 3; i++)
            {
                p.up();
            }
            for (int i = 0; i < 2; i++)
            {
                p.left();
            }
            for (int i = 0; i < 2; i++)
            {
                p.down();
            }
            for (int i = 0; i < 2; i++)
            {
                p.right();
            }
            for (int i = 0; i < 1; i++)
            {
                p.down();
            }
            for (int i = 0; i < 1; i++)
            {
                p.right();
            }
            for (int i = 0; i < 4; i++)
            {
                p.up();
            }
            for (int i = 0; i < 1; i++)
            {
                p.right();
            }
            for (int y = 0; y < 5; y++)
            {
                for (int i = 0; i < 1; i++)
                {
                    p.up();
                }
                for (int i = 0; i < 1; i++)
                {
                    p.left();
                }
            }

            p.endLine();
        }
    }
}
