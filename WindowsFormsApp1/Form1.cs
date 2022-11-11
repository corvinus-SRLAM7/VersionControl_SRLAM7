using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks;
        List<PortofioItem> Portfolio = new List<PortofioItem>();

        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;
            CreatePortfolio();
        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortofioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortofioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortofioItem() { Index = "ELMU", Volume = 10 });

            dataGridView1.DataSource = Portfolio;
        }
    }
}
