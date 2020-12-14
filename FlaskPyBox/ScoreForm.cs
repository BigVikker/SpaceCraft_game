using FlaskPyBox.Score;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlaskPyBox
{
    public partial class ScoreForm : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private List<ScoreClass> listScore = new List<ScoreClass>();
        private int positions = 0;
        public int Diem { get; set; }
        public MainForm mainForms { get; set; }
        public ScoreForm(MainForm mainForm, int score)
        {
            this.mainForms = mainForm;
            this.mainForms.Enabled = false;
            Diem = score;
            InitializeComponent();
            string[] lines = File.ReadAllLines("Result.txt");
            foreach (var i in lines)
            {
                string[] temp = i.Split();
                ScoreClass newOne = new ScoreClass(temp[0].ToString(), Convert.ToInt32(temp[1]));
                listScore.Add(newOne);
            }
            for (int i = 0; i < listScore.Count; i++)
            {
                if (listScore[i].score <= score)
                {
                    positions = i;
                    break;
                }
            }
            if (positions != 0)
            {
                ScoreClass newone = new ScoreClass("You", score);
                listScore.Insert(positions, newone);
            }
            for (int i = 0; i < 10; i++)
            {
                this.dataGridView1.Rows.Add(i + 1, listScore[i].name, listScore[i].score);
            }
            label_score.Text = "Score: " + score;
            if (positions != 0)
            {
                label_score.Text += "  Top: " + Convert.ToInt32(positions + 1).ToString();
                dataGridView1.CurrentCell = dataGridView1.Rows[positions].Cells[1];

            }
            else
            {
                label_score.Text += "  Top: UnRank";
                textBox_Name.Hide();
                label_name.Hide();
                dataGridView1.CurrentCell = null;
            }
            dataGridView1.ReadOnly = true;
        }
        private void AddToScoreBoard(ScoreClass newOne)
        {
            if(positions != 0)
            {
                string[] lines = File.ReadAllLines("Result.txt");
                using (StreamWriter writer = new StreamWriter("Result.txt"))
                {
                    for (int i = 0; i < positions; i++)
                        writer.WriteLine(lines[i]);
                    writer.WriteLine(newOne.name + " " + newOne.score);
                    for (int i = positions; i < (lines.Length - 1); i++)
                        writer.WriteLine(lines[i]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[positions].Cells[1].Value = textBox_Name.Text.ToString();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (positions != 0)
            {
                ScoreClass newOne = new ScoreClass(dataGridView1.Rows[positions].Cells[1].Value.ToString(), Diem);
                string[] lines = File.ReadAllLines("Result.txt");
                using (StreamWriter writer = new StreamWriter("Result.txt"))
                {
                    for (int i = 0; i < positions; i++)
                        writer.WriteLine(lines[i]);
                    writer.WriteLine(newOne.name + " " + newOne.score);
                    for (int i = positions; i < (lines.Length - 1); i++)
                        writer.WriteLine(lines[i]);
                }
            }
            Close();
        }

        private void ScoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForms.Enabled = true;
        }

        private void button_submit_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;
            return;
        }

        private void textBox_Name_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
