using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listHero = new List<HeroModel>
            {
                new HeroModel("Saber", "Assasin"),
                new HeroModel("Karina", "Assasin"),
                new HeroModel("Fanny", "Assasin"),
                new HeroModel("Hayabusa", "Assasin"),
                new HeroModel("Natalia", "Assasin"),
                new HeroModel("Helcurt", "Assasin"),
                new HeroModel("Gusion", "Assasin"),
                new HeroModel("Hanzo", "Assasin"),
                new HeroModel("Balmond", "Fighter"),
                new HeroModel("Freya", "Fighter"),
                new HeroModel("Chou", "Fighter"),
                new HeroModel("Sun", "Fighter"),
                new HeroModel("Alpha", "Fighter"),
                new HeroModel("Ruby", "Fighter"),
                new HeroModel("Lapu-Lapu", "Fighter"),
                new HeroModel("Argus", "Fighter"),
                new HeroModel("Eudora", "Mage"),
                new HeroModel("Gord", "Mage"),
                new HeroModel("Kagura", "Mage"),
                new HeroModel("Cyclops", "Mage"),
                new HeroModel("Odette", "Mage"),
                new HeroModel("Vale", "Mage"),
                new HeroModel("Lunox", "Mage"),
                new HeroModel("Valir", "Mage"),
                new HeroModel("Layla", "Marksman"),
                new HeroModel("Moskov", "Marksman"),
                new HeroModel("Karrie", "Marksman"),
                new HeroModel("Hanabi", "Marksman"),
                new HeroModel("Wanwan", "Marksman"),
                new HeroModel("Brody", "Marksman"),
                new HeroModel("Beatrix", "Marksman"),
                new HeroModel("Natan", "Marksman"),
                new HeroModel("Tigreal", "Tank"),
                new HeroModel("Akai", "Tank"),
                new HeroModel("Franco", "Tank"),
                new HeroModel("Hylos", "Tank"),
                new HeroModel("Belerick", "Tank"),
                new HeroModel("Uranus", "Tank"),
                new HeroModel("Khufra", "Tank"),
                new HeroModel("Atlas", "Tank"),
                new HeroModel("Mathilda", "Support"),
                new HeroModel("Faramis", "Support"),
                new HeroModel("Angela", "Support"),
                new HeroModel("Diggie", "Support"),
                new HeroModel("Estes", "Support"),
                new HeroModel("Kaja", "Support")
            };

            treeView1.Nodes.Add("Assasin", "Assasin");
            treeView1.Nodes.Add("Fighter", "Fighter");
            treeView1.Nodes.Add("Mage", "Mage");
            treeView1.Nodes.Add("Marksman", "Marksman");
            treeView1.Nodes.Add("Tank", "Tank");
            treeView1.Nodes.Add("Support", "Support");

            foreach(var item in listHero)
                treeView1.Nodes[item.Role].Nodes.Add(item.HeroName);

        }

        private class HeroModel
        {
            public HeroModel(string name, string role)
            {
                HeroName = name;
                Role = role;
            }
            public string HeroName { get; set; }
            public string Role { get; set; }
        }
    }
}
