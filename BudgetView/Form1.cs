using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections;

namespace BudgetView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Checking if input field text is int
        public Boolean isDouble(string current_input)
        {
            try
            {
                Convert.ToDouble(current_input);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        //method to gather, validate and convert text fields to JSON
        public string serializeInputToJSON(TableLayoutPanel currentTableLayoutPanel)
        {
            try
            {
                //New array to save values
                string[,] inputValues = new string[currentTableLayoutPanel.RowCount, 2];



                //Read all rows
                for (int i = 0; i < currentTableLayoutPanel.RowCount; i++)
                {
                    //TODO: Fill array with lbl text (descr.)
                    //Read lbl text 
                    //Assign control from table layout panel to new control. Should be LABEL type
                    Control currentControlLabel = currentTableLayoutPanel.GetControlFromPosition(0, i);
                    //Check if type is Label & text is not empty
                    if (currentControlLabel is Label && currentControlLabel.Text != "")
                    {
                        //write to array
                        inputValues[i, 0] = currentControlLabel.Name;
                        MessageBox.Show("LABEL YES!)");
                    }
                    else
                    {
                        MessageBox.Show("NYET LABEL CYKA!)");
                    }

                    //Read, validate & write INPUT FROM TEXTBOX 
                    //Assign control from table layout panel to new control. Should be TextBox type
                    Control currentControlTextBox = currentTableLayoutPanel.GetControlFromPosition(1, i);
                    //Check if type is TextBox & text is not empty
                    if (currentControlTextBox is TextBox && currentControlTextBox.Text != "")
                    {
                        //check if current val is double
                        if (isDouble(currentControlTextBox.Text))
                        {
                            //write to array
                            inputValues[i, 1] = currentControlTextBox.Text;
                        }

                        MessageBox.Show("TEXT & INT yes!)");
                    }
                    else
                    {
                        MessageBox.Show("NYET TEXT & INT CYKA!)");
                    }
                }
                string inputAsJSON = "";
                return inputAsJSON = JsonConvert.SerializeObject(inputValues);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private void btnSubmitIn_Click(object sender, EventArgs e)
        {
            try
            {
                //Gather data, val. and converto json
                string inputAsJSON = serializeInputToJSON(tableLayoutPanelIn);

                //write json to file
                System.IO.File.WriteAllText(@"D:\income.json", inputAsJSON);
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSubmitOut_Click(object sender, EventArgs e)
        {
            try
            {
                //Gather data, val. and converto json
                string inputAsJSON = serializeInputToJSON(tableLayoutPanelOut);

                //write json to file
                System.IO.File.WriteAllText(@"D:\expense.json", inputAsJSON);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
