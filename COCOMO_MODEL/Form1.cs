using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO_MODEL
{
    public partial class Form1 : Form
    {
        private ProjectType projectType;
        private int codeSize;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            codeSize = 0;
            projectTypeList.SelectedIndex = 0;
            projectType = (ProjectType)projectTypeList.SelectedIndex;

        }

        private void CodeSizeField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                codeSize = int.Parse(codeSizeField.Text);

            }
            catch
            {              
                MessageBox.Show("Invalid data. Try Again!");
                codeSizeField.Text = 0.ToString();
            }

        }

        private void ProjectTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            projectType = (ProjectType)projectTypeList.SelectedIndex;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(codeSizeField.Text))
            {
                COCOCMO_Model cocomoCalculation = new COCOCMO_Model(codeSize, projectType);
                effortsLabel.Text = string.Format("{0} {1}", cocomoCalculation.GetEfforts().ToString("F2"), " люд/міс.");
                timeToDevelopLabel.Text = string.Format("{0} {1}", cocomoCalculation.GetTimeToDevelop().ToString("F2"), " міс.");
                personsToDevelop.Text = string.Format("{0} {1} {2}", cocomoCalculation.GetPersonsToDevelop().ToString("F2"), " люд. ≈ ", Convert.ToInt32(cocomoCalculation.GetPersonsToDevelop()).ToString());

                productivityLabel.Text = cocomoCalculation.GetProductivity().ToString("F2");

            }
        }
    }
}
