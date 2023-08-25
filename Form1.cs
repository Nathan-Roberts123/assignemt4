using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace APP_deve_practical_project
{
    public partial class Form1 : Form
    {

        double amountDue;
        String location = Application.StartupPath + "\\Fitness.txt";


        public Form1()
        {
            InitializeComponent();
            GymnasiumRadio.Checked = true;
            Radio1hour.Checked = true;
            StudentRadio.Checked = true;
        }

        private void SwimmingPoolRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void saveOutPut(String message)
        {
            StreamWriter writer = new StreamWriter(Application.StartupPath + "\\..\\..\\Fitness.txt");
            writer.WriteLine(message);
            writer.Close();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MembershipNumber.Text))
                {
                    throw new NullReferenceException("You must enter your membership number");
                }

                if (StudentRadio.Checked || StaffRadio.Checked)
                {
                    String text = "Booking of facilities for student and staff is free of change";
                    message.Text = text;
                    saveOutPut(text);
     
                }
                else
                {
                    if (SquashCourtRadio.Checked == true)
                    {
                        if (Radio30min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 0.5 * 13 + 0.65 + 1.001;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            } else
                            {
                                amountDue = 0.5 * 13 + 0.91;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                        else if (Radio1hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 1 * 13 + 1.3 + 2.002;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 1 * 13 + 1.82;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                        else if (Radio90min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 1.5 * 13 + 1.95 + 3.003;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 1.5 * 13 + 2.73;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                        else if (Radio2hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 2 * 13 + 2.6 + 4.004;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 2 * 13 + 3.64;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                    }

                    else if (SwimmingPoolRadio.Checked == true)
                    {
                        if (Radio30min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 0.5 * 11 + 0.55 + 0.847;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }
                            else
                            {
                                amountDue = 0.5 * 11 + 0.77;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }

                        }
                        else if (Radio1hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 1 * 11 + 1.1 + 1.694;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }
                            else
                            {
                                amountDue = 1 * 11 + 1.54;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }

                        }
                        else if (Radio90min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 1.5 * 11 + 1.65 + 2.541;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }
                            else
                            {
                                amountDue = 1.5 * 11 + 2.31;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }

                        }
                        else if (Radio2hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 2 * 11 + 2.2 + 3.388;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }
                            else
                            {
                                amountDue = 2 * 11 + 3.08;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }

                        }
                    }

                    else if (GymnasiumRadio.Checked == true)
                    {
                        if (Radio30min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 0.5 * 11 + 0.55 + 0.847;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 0.5 * 11 + 0.77;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                        else if (Radio1hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 1 * 11 + 1.1 + 1.694;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 1 * 11 + 1.54;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }

                        }
                        else if (Radio90min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 1.5 * 11 + 1.65 + 2.541;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 1.5 * 11 + 2.31;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                        else if (Radio2hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 2 * 11 + 2.2 + 3.388;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 2 * 11 + 3.08;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                    }

                    else if (WeightsRadio.Checked == true)
                    {
                        if (Radio30min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 0.5 * 8 + 0.4 + 0.224;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 0.5 * 8 + 0.56;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                        else if (Radio1hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 1 * 8 + 0.8 + 1.232;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 1 * 8 + 1.12;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                        else if (Radio90min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 1.5 * 8 + 1.2 + 1.848;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 1.5 * 8 + 1.63;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);

                            }

                        }
                        else if (Radio2hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                amountDue = 2 * 8 + 1.6 + 2.464;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }
                            else
                            {
                                amountDue = 2 * 8 + 2.24;
                                String text = $"The amount due for the facilities for member {MembershipNumber.Text} = {amountDue}";
                                message.Text = text;
                                saveOutPut(text);
                            }

                        }
                    }
                }

            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            message.Text = " ";
            GymnasiumRadio.Checked = true;
            Radio1hour.Checked = true;
            StudentRadio.Checked = true;
            MembershipNumber.Text = "";
            this.ActiveControl = MembershipNumber;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
