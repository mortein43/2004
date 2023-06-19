using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004
{
    public partial class Form1 : Form
    {
        private static Timer vTimer = new Timer();
        private void ShowTime(object vObj, EventArgs e)
        {
            //перетворення в рядок
            label1.Text = DateTime.Now.ToLongTimeString();
        }
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
            //закріплення обробника
            vTimer.Tick += new EventHandler(ShowTime);
            //встановлення інтервалу часу
            vTimer.Interval = 1000;
            // запускаємо таймер
            vTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
