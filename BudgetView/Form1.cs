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
using Newtonsoft.Json.Linq;
using System.IO;

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
        public string serializeInputToJSON(TableLayoutPanel currentTableLayoutPanel, Boolean isExpense)
        {
            try
            {
                //New array to save values
                string[] inputValues = new string[currentTableLayoutPanel.RowCount];

                //Read all rows
                for (int i = 0; i < currentTableLayoutPanel.RowCount; i++)
                {
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
                            inputValues[i] = currentControlTextBox.Text;
                        }

                    }

                }

                if (isExpense)
                {

                   Expense dataTransferObject = new Expense(inputValues);
                    return JsonConvert.SerializeObject(dataTransferObject);
                }
                else
                {
                    //TODO: create class and object
                    Expense dataTransferObject = new Expense(inputValues);
                    return JsonConvert.SerializeObject(dataTransferObject);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("KRITISCHER FEHLER BEI JSON KONVERTIERUNG: " + ex.Message);
                return null;
            }
        }

        private void btnSubmitIn_Click(object sender, EventArgs e)
        {
            try
            {
                //Gather data, val. and converto json
                var inputAsJSON = serializeInputToJSON(tableLayoutPanelIn, false);

                //write json to file
               

              //  System.IO.File.AppendAllText(@"D:\income.json", inputAsJSON);
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSubmitOut_Click(object sender, EventArgs e)
        {
            try
            {
                //Gather input data, val. and converto json
                var jsonStringFromInput = serializeInputToJSON(tableLayoutPanelOut, true);
          


                //write json to file
                System.IO.File.AppendAllText(@"D:\expense.json", jsonStringFromInput);

                //ignore for now
                /* using (StreamWriter file = File.CreateText(@"D:\expense.json"))
                 {
                     JsonSerializer serializer = new JsonSerializer();
                     serializer.Serialize(file, inputAsJSON);
                 }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("KRITISCHER FEHLER BEI JSON KONVERTIERUNG: " + ex.Message);
            }
        }
    }
}
