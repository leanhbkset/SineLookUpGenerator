using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SineLookUpGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioDecimal.Checked = true;
            lblNoOfPointsMsg.Text = "";
            lblVoltageMsg.Text = "";
            lblMaxVoltageMSG.Text = "";
            lblNoPerRowMsg.Text = "";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            richtxtResults.Text = "";
            lblNoOfPointsMsg.Text = "";
            lblVoltageMsg.Text = "";
            lblMaxVoltageMSG.Text = "";
            lblNoPerRowMsg.Text = "";
            bool generator_flag = true;
            TextBox obj_user_select;
            int _no_points = 0;
            double _voltage = 0;
            double _max_voltage = 0;
            int _no_per_row = 0;

            obj_user_select = (TextBox)txtNoOfPoints;
            if (obj_user_select.Text == "")
            {
                generator_flag = false;
                lblNoOfPointsMsg.Text = "Please input value";
            }
            else
            {
                _no_points = int.Parse(obj_user_select.Text);
            }
            
            obj_user_select = (TextBox)txtVoltage;
            if (obj_user_select.Text == "")
            {
                generator_flag = false;
                lblVoltageMsg.Text = "Please input value";
            }
            else
            {
                _voltage = int.Parse(obj_user_select.Text);
            }
            
            obj_user_select = (TextBox)txtMaxVoltage;
            if (obj_user_select.Text == "")
            {
                generator_flag = false;
                lblMaxVoltageMSG.Text = "Please input value";
            }
            else
            {
                _max_voltage = int.Parse(obj_user_select.Text);
            }
            
            obj_user_select = (TextBox)txtNoPerRow;
            if (obj_user_select.Text == "")
            {
                generator_flag = false;
                lblNoPerRowMsg.Text = "Please input value";
            }
            else
            {
                _no_per_row = int.Parse(obj_user_select.Text);
            }

            if (_voltage > _max_voltage )
            {
                generator_flag = false;
                lblVoltageMsg.Text = "Please input 'Voltage Value' less than 'Max Voltage Value'";
            }

            if (_no_per_row > _no_points)
            {
                generator_flag = false;
                lblNoPerRowMsg.Text = "Please input 'Numbers Per Row' less than 'Number of points'";
            }

            if (generator_flag == true)
            {
                List<int> _results = new List<int>();
                int _data = 0;
                for (int i = 0; i < _no_points; i++)
                {
                    _data = (int)((_voltage * 100 / _max_voltage) * Math.Sin(i * Math.PI / _no_points));
                    _results.Add(_data);
                }

                for (var i = 0; i < _results.Count; i++)
                {
                    if (i % _no_per_row == 0 && i != 0)
                    {
                        richtxtResults.Text = richtxtResults.Text + "\n";
                    }

                    if (radioDecimal.Checked)
                    {
                        if (_results[i] < 10 && _results[i] >= 0)
                        {
                            richtxtResults.Text = richtxtResults.Text + "0" + _results[i].ToString() + ", ";
                        }
                        else
                        {
                            richtxtResults.Text = richtxtResults.Text + _results[i].ToString() + ", ";
                        }
                    }
                    else if (radioHex.Checked)
                    {
                        if (_results[i] < 10 && _results[i] >= 0)
                        {
                            richtxtResults.Text = richtxtResults.Text + "0x0" + _results[i].ToString("x") + ", ";
                        }
                        else
                        {
                            richtxtResults.Text = richtxtResults.Text + "0x" + _results[i].ToString("x") + ", ";
                        }
                    }
                }
            }
        }
    }
}
