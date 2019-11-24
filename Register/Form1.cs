using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void AddChildButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("What is the child's name?", "Add child", "", 0, 0);
            if( input.Length > 0 ) {
                dataGridView1.Rows.Add(input, "", false, false, "");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "rsr"
            };

            if( sfd.ShowDialog() == DialogResult.OK )
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(sfd.FileName, FileMode.Create)))
                {
                    bw.Write(dataGridView1.Columns.Count);
                    bw.Write(dataGridView1.Rows.Count);
                    foreach (DataGridViewRow dgvR in dataGridView1.Rows)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                        {
                            object val = dgvR.Cells[j].Value;
                            if (val == null)
                            {
                                bw.Write(false);
                                bw.Write(false);
                            }
                            else
                            {
                                bw.Write(true);
                                bw.Write(val.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog
            {
                DefaultExt = "rsr"
            };
            if( ofd.ShowDialog() == DialogResult.OK )
            {
                dataGridView1.DataSource = null;
                using (BinaryReader bw = new BinaryReader(File.Open(ofd.FileName, FileMode.Open)))
                {
                    int n = bw.ReadInt32();
                    int m = bw.ReadInt32();
                    for (int i = 0; i < m; ++i)
                    {
                        dataGridView1.Rows.Add();
                        for (int j = 0; j < n; ++j)
                        {
                            if (bw.ReadBoolean())
                            {
                                dataGridView1.Rows[i].Cells[j].Value = bw.ReadString();
                            }
                            else bw.ReadBoolean();
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MoveDown()
        {
            if (dataGridView1.CurrentCell.RowIndex < dataGridView1.RowCount - 1)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[0];
            }
        }


        private int GetColumnToTick()
        {
            int columnToTick = 2;
            if (timeOfDayBox.SelectedIndex > 0)
            {
                columnToTick = 3;
            }
            return columnToTick;
        }

        private void PresentButton_Click(object sender, EventArgs e)
        {
            
            dataGridView1.CurrentRow.Cells[GetColumnToTick()].Value = true;
            MoveDown();
        }

        private void AbsentButton_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[GetColumnToTick()].Value = false;
            MoveDown();
        }
    }
}
