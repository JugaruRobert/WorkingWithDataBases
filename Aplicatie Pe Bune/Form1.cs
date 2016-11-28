using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Aplicatie_Pe_Bune
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbConnection connection2 = new OleDbConnection();
        public OleDbCommand comand;
        public class Global
        {
            public static bool ok = false, ok1 = false, ok2=false;
            public static string text1;
            public static int aux = 0, aux1 = 0, aux2 = 0 ,aux3=1 ,aux4=0,c=1;
        } 
        public Form1()
        {
            
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Aplicatie calendar\Database2.accdb;Persist Security Info=False;";
            connection2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Aplicatie calendar\Database3.accdb;Persist Security Info=False;";
            label2.Visible = false;
            label3.Visible = false;
            button2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;

            try
            {
                
                
                connection.Open();
                label4.Text = "Connected to the database";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            try
            {

                connection2.Open();
                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            menuStrip1.Visible = true;
            label2.Visible = true;
            resetToolStripMenuItem.Visible = true;
            label3.Visible = true;
            button2.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            label1.Visible = false;
            
            button3.Visible = false;
            button4.Visible = false;
            resetToolStripMenuItem.Visible = true;
            button5.Visible = true;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            label3.Visible = false;
            button2.Enabled = false;
            
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
       
            

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            resetToolStripMenuItem.Visible = false; 
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string var1 = "";
            if (Global.aux1 == 1)
            {
                if (comboBox1.Text != var1)
                {
                    label3.Visible = false;
                   
                }

            }
            else
            {
                var1 = comboBox1.Text;
                Global.aux1 = 1;
            }

            if (comboBox2.Text != null)
                comboBox3.Enabled = true;
            if (comboBox2.Text == "January")
            {
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    
                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    Global.ok1 = false;
                }
                if (Global.ok2 == true)
                {
                    comboBox3.Items.Add("31");
                    Global.ok2 = false;
                }
            }

            if (comboBox2.Text == "February")
            {
                int x = int.Parse(comboBox1.SelectedItem.ToString());
                if (x % 4 == 0)
                {
                    comboBox3.Items.Remove("29");
                    comboBox3.Items.Remove("30");
                    comboBox3.Items.Remove("31");
                    Global.ok = true;
                }
                else
                {
                    if (Global.ok == true)
                    {
                        comboBox3.Items.Add("29");
                        Global.ok = false;
                        Global.ok1 = true;
                    }
                    else
                    {
                        comboBox3.Items.Remove("30");
                        comboBox3.Items.Remove("31");
                        Global.ok = false;
                        Global.ok1 = true;
                    }
                }

            }
            if (comboBox2.Text == "March")
            {
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");

                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    Global.ok1 = false;
                }
                if (Global.ok2 == true)
                {
                    comboBox3.Items.Add("31");
                    Global.ok2 = false;
                }
            }
            if (comboBox2.Text == "May")
            {
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");

                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    Global.ok1 = false;
                }
                if (Global.ok2 == true)
                {
                    comboBox3.Items.Add("31");
                    Global.ok2 = false;
                }
            }
            if (comboBox2.Text == "July")
            {
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");

                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    Global.ok1 = false;
                }
                if (Global.ok2 == true)
                {
                    comboBox3.Items.Add("31");
                    Global.ok2 = false;
                }
            }
            if (comboBox2.Text == "August")
            {
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");

                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    Global.ok1 = false;
                }
                if (Global.ok2 == true)
                {
                    comboBox3.Items.Add("31");
                    Global.ok2 = false;
                }
            }
            if (comboBox2.Text == "October")
            {
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");

                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    Global.ok1 = false;
                }
                if (Global.ok2 == true)
                {
                    comboBox3.Items.Add("31");
                    Global.ok2 = false;
                }
            }
            if (comboBox2.Text == "December")
            {
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");

                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    Global.ok1 = false;
                }
                if (Global.ok2 == true)
                {
                    comboBox3.Items.Add("31");
                    Global.ok2 = false;
                }
            }

            if (comboBox2.Text == "April")
            {
                if (Global.ok == false && Global.ok1 == false && Global.ok2 == false)
                    comboBox3.Items.Remove("31");
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    Global.ok1 = false;
                }
                Global.ok2 = true;
            }

            if (comboBox2.Text == "June")
            {
                if (Global.ok == false && Global.ok1 == false && Global.ok2 == false)
                    comboBox3.Items.Remove("31");
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    Global.ok1 = false;
                }
                Global.ok2 = true;
            }
            if (comboBox2.Text == "September")
            {
                if (Global.ok == false && Global.ok1 == false && Global.ok2 == false)
                    comboBox3.Items.Remove("31");
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    Global.ok1 = false;
                }
                Global.ok2 = true;
            }
            if (comboBox2.Text == "November")
            {
                if (Global.ok == false && Global.ok1 == false && Global.ok2 == false)
                    comboBox3.Items.Remove("31");
                if (Global.ok == true)
                {
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    Global.ok = false;
                }
                if (Global.ok1 == true)
                {
                    comboBox3.Items.Add("30");
                    Global.ok1 = false;
                }
                Global.ok2 = true;
            }

            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var2 = "";
            if (Global.aux2 == 1)
            {
                if (comboBox1.Text != var2)
                {
                    label3.Visible = false;
                }

            }
            else
            {
                var2 = comboBox1.Text;
                Global.aux2 = 1;
            }

            if(comboBox3.Text!=null && comboBox2.Text!=null && comboBox3.Text!=null)
            {
                button2.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string var = "";
            if (Global.aux == 1)
            {
                if (comboBox1.Text != var)
                {
                    comboBox2.Enabled = false;
                    comboBox2.Text = null;
                    label3.Visible = false;
                    comboBox3.Enabled = false;
                    comboBox3.Text = null;
                    button2.Enabled = false;
          
                }

            }
            else
            {
               
                var = comboBox1.Text;
                Global.aux = 1;
            }
            if (comboBox1.Text != Global.text1 && comboBox2.Text == "February")
            {
                comboBox2.Text = "January";
                
                comboBox3.Enabled = false;
                comboBox3.Text = null;
                button2.Enabled = false;
                
               
            }

            if(comboBox1.Text != null)
            {

                comboBox2.Enabled = true;
                Global.text1 = comboBox1.Text;
            }
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int an, luna = 0, zi, fd = 0, ld = 0, m = 0, ziua;
            int cc = 0, y = 0;
            an = int.Parse(comboBox1.SelectedItem.ToString());
            if(comboBox2.Text=="January")
            {
                luna = 1;

            }
            if (comboBox2.Text == "February")
            {
                luna = 2;

            }
            if (comboBox2.Text == "March")
            {
                luna = 3;

            }
            if (comboBox2.Text == "April")
            {
                luna = 4;

            }
            if (comboBox2.Text == "May")
            {
                luna = 5;

            }
            if (comboBox2.Text == "June")
            {
                luna = 6;

            }
            if (comboBox2.Text == "July")
            {
                luna = 7;

            }
            if (comboBox2.Text == "August")
            {
                luna = 8;

            }
            if (comboBox2.Text == "September")
            {
                luna = 9;

            }
            if (comboBox2.Text == "October")
            {
                luna = 10;

            }
            if (comboBox2.Text == "November")
            {
                luna = 11;

            }
            if (comboBox2.Text == "December")
            {
                luna = 12;

            }
            zi = int.Parse(comboBox3.SelectedItem.ToString());

            
                

                if (an / 10 % 10 == 0)
                    fd = an % 10;
                else
                    fd = (an / 10 % 10) * 10 + an % 10;

                ld = an / 100 % 10 + (an / 1000 % 10) * 10;


                if (ld % 4 == 0)
                    cc = 6;
                if (ld % 4 == 1)
                    cc = 4;
                if (ld % 4 == 2)
                    cc = 2;
                if (ld % 4 == 3)
                    cc = 0;

                y = ((fd + cc) % 7 + fd / 4 % 7);

                if (luna == 1)
                    m = 1;
                if (luna == 2)
                    m = 4;
                if (luna == 3)
                    m = 4;
                if (luna == 4)
                    m = 0;
                if (luna == 5)
                    m = 2;
                if (luna == 6)
                    m = 5;
                if (luna == 7)
                    m = 0;
                if (luna == 8)
                    m = 3;
                if (luna == 9)
                    m = 6;
                if (luna == 10)
                    m = 1;
                if (luna == 11)
                    m = 4;
                if (luna == 12)
                    m = 6;

                ziua = (y + m + zi) % 7;
                if (ziua == 0)
                {
                  label3.Text=("Saturday");
                }
                if (ziua == 1)
                {label3.Text=("Sunday");
                }
                if (ziua == 2)
                {label3.Text=("Monday");
                }
                if (ziua == 3)
                {label3.Text=("Tuesday");
                }
                if (ziua == 4)
                {label3.Text=("Wednesday");
                }
                if (ziua == 5)
                {label3.Text=("Thursday");
                }
                if (ziua == 6)
                {label3.Text=("Friday");
                }
                if (label3.Text == "Monday" || label3.Text == "Tuesday" ||  label3.Text == "Thursday" || label3.Text == "Saturday")
                {
                    label3.Location = button7.Location;
                }
                if (label3.Text == "Friday" || label3.Text == "Sunday")
                {
                    label3.Location = button6.Location;
                }
            if(label3.Text=="Wednesday")
            {
                label3.Location = button8.Location;
            }
            if(comboBox1.Text!=null &&comboBox2.Text!=null && comboBox3.Text!=null)
            {
               




            }

            if(comboBox3.Text==null && comboBox2.Text==null && comboBox1.Text==null)
            {
                button2.Enabled = false;
            }
            label3.Visible = true;

            }

        private void button1_Click(object sender, EventArgs e)
        {
            
            comboBox4.Text = null;
            label1.Visible = false;
         
            button3.Visible = false;
            button4.Visible = false;
            comboBox4.Visible = true;
            button5.Visible = true;
            label10.Visible = true;
            
            
            
            
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            if (comboBox1.Text == null && comboBox2.Text == null && comboBox3.Text == null)
            {
                button2.Enabled = false;

            }
            if (comboBox3.Enabled == false)
                button2.Enabled = false;
            label3.Visible = false;
         
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application made by : Neghina Daniel & Jugaru Robert ", " Authors ");
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            comboBox3.Visible = false;
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            button3.Visible = true;
           
            button4.Visible = true;
            label1.Visible = true;
            monthCalendar2.Visible = false;
            button5.Visible = false;
            button11.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button15.Visible = false;
            button11.Visible = false;
            label10.Visible = false;
            
            comboBox4.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            label10.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            label1.Visible = true;
           
            button3.Visible = true;
            button4.Visible = true;
            resetToolStripMenuItem.Visible = false;            
            groupBox1.Visible = false;
            monthCalendar2.Visible = false;
           

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("• This aplication is working with calendar dates.                                                                                                                                                                                                              • By pressing the first button you will have the options to Log in or to Register and by logging in you will be able to see a calendar.                                                                                                                                                                                                             • Pressing the second button will give you the option to pick a calendar date , to find out what day of the week was in that date                                                                                                                                                                                                           •By pressing the third button wou can find out events related to science , sport or economy that happened in a certain year   ","About the application");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            groupBox1.Visible = true;
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            
            int r = 1;
            if (Global.aux3 == 1)
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = " select * from Table1 where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int nr = 0;
                while (reader.Read())
                {
                    nr++;
                }
           
                if (r == 1)
                {
                    r = 0;
                    if (textBox1.Text == "" && textBox2.Text != "")
                    {
                        MessageBox.Show("Please write the username");
                        r = 1;
                    }


                    if (textBox1.Text != "" && textBox2.Text == "")
                    {
                        MessageBox.Show("Please write the password");
                        r = 1;
                    }
                    if (textBox1.Text == "" && textBox2.Text == "")
                    {
                        MessageBox.Show("Please write the username and the password");
                        r = 1;
                    }
                     
                }
                if(r==0)
                {
                    if (nr == 1)
                    {

                        groupBox1.Visible = false;
                        monthCalendar2.Visible = true;
                        monthCalendar2.Location = button10.Location;
                        button5.Visible = false;
                        button11.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Username or password is not correct");
                    }
                }
                connection.Close();
            }
            else
                MessageBox.Show("Not connected to the database");
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = false;
            groupBox1.Visible = true;
            button5.Visible = true;
            button11.Visible = false;
            textBox2.Text = null;
            textBox1.Text = null;
        }



        private void button12_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            button5.Visible = false;
            button15.Visible = true;
            textBox3.Text = "";
            textBox4.Text = "";

        }



        private void button15_Click(object sender, EventArgs e)
        {
            
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            button15.Visible = false;
            button5.Visible = true;
            
            textBox1.Text = "";
            textBox2.Text = "";
        }



        private void button13_Click(object sender, EventArgs e)
        {
            if (Global.aux3 == 1)
            {
                int c = 1;
                if (c == 1)
                {
                    c = 0;
                    if (textBox4.Text == "" && textBox3.Text != "")
                    {
                        MessageBox.Show("Please write the username");
                        c = 1;
                    }


                    if (textBox4.Text != "" && textBox3.Text == "")
                    {
                        MessageBox.Show("Please write the password");
                        c = 1;
                    }
                    if (textBox3.Text == "" && textBox4.Text == "")
                    {
                        MessageBox.Show("Please write the username and the password");
                        c = 1;
                    }


                }
                if (c == 0)
                {
                    OleDbCommand command = new OleDbCommand();
                    command.CommandText = "INSERT INTO Table1 ([Username] , [Password]) VALUES(@name,@pass)";
                    command.Parameters.AddWithValue("@user", textBox4.Text);
                    command.Parameters.AddWithValue("@pass", textBox3.Text);
                    connection.Open();
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Succesufully registered");
                    groupBox2.Visible = false;
                    button15.Visible = false;
                    groupBox1.Visible = true;
                    button11.Visible = true;
                    button5.Visible = false;

                }
            }
            else
                MessageBox.Show("Not connected to the database");


        }



        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar2.TitleBackColor = System.Drawing.Color.LightBlue;
            monthCalendar2.TrailingForeColor = System.Drawing.Color.Red;
            monthCalendar2.TitleForeColor = System.Drawing.Color.Yellow;
            
        }




        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label4.Text = "Connected to the database";
            Global.aux3 = 1;
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            connection.Close();
            label4.Text = "Not connected to the database";
            Global.aux3 = 0;
        }





        


       

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Location = label9.Location;
            richTextBox1.Visible = true;
            
            comboBox4.Visible = false;
            label10.Visible = false;
            button22.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox2.Location = label9.Location;
            richTextBox2.Visible = true;

            comboBox4.Visible = false;
            label10.Visible = false;
            button22.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox3.Location = label9.Location;
            richTextBox3.Visible = true;
           
            comboBox4.Visible = false;
            label10.Visible = false;
            button22.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox4.Location = label9.Location;
            richTextBox4.Visible = true;
            
            comboBox4.Visible = false;
            label10.Visible = false;
            button22.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox5.Location = label9.Location;
            richTextBox5.Visible = true;
            
            comboBox4.Visible = false;
            label10.Visible = false;
            button22.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            richTextBox4.Visible = false;
            richTextBox5.Visible = false;
            label10.Visible = true;
            comboBox4.Visible = true;
            
            button22.Visible = false;
            
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int an, luna = 0, zi, fd = 0, ld = 0, m = 0, ziua;
            int cc = 0, y = 0;
            an = int.Parse(comboBox1.SelectedItem.ToString());
            if (comboBox2.Text == "January")
            {
                luna = 1;

            }
            if (comboBox2.Text == "February")
            {
                luna = 2;

            }
            if (comboBox2.Text == "March")
            {
                luna = 3;

            }
            if (comboBox2.Text == "April")
            {
                luna = 4;

            }
            if (comboBox2.Text == "May")
            {
                luna = 5;

            }
            if (comboBox2.Text == "June")
            {
                luna = 6;

            }
            if (comboBox2.Text == "July")
            {
                luna = 7;

            }
            if (comboBox2.Text == "August")
            {
                luna = 8;

            }
            if (comboBox2.Text == "September")
            {
                luna = 9;

            }
            if (comboBox2.Text == "October")
            {
                luna = 10;

            }
            if (comboBox2.Text == "November")
            {
                luna = 11;

            }
            if (comboBox2.Text == "December")
            {
                luna = 12;

            }
            zi = int.Parse(comboBox3.SelectedItem.ToString());




            if (an / 10 % 10 == 0)
                fd = an % 10;
            else
                fd = (an / 10 % 10) * 10 + an % 10;

            ld = an / 100 % 10 + (an / 1000 % 10) * 10;


            if (ld % 4 == 0)
                cc = 6;
            if (ld % 4 == 1)
                cc = 4;
            if (ld % 4 == 2)
                cc = 2;
            if (ld % 4 == 3)
                cc = 0;

            y = ((fd + cc) % 7 + fd / 4 % 7);

            if (luna == 1)
                m = 1;
            if (luna == 2)
                m = 4;
            if (luna == 3)
                m = 4;
            if (luna == 4)
                m = 0;
            if (luna == 5)
                m = 2;
            if (luna == 6)
                m = 5;
            if (luna == 7)
                m = 0;
            if (luna == 8)
                m = 3;
            if (luna == 9)
                m = 6;
            if (luna == 10)
                m = 1;
            if (luna == 11)
                m = 4;
            if (luna == 12)
                m = 6;

            ziua = (y + m + zi) % 7;
            if (ziua == 0)
            {
                label3.Text = ("Saturday");
            }
            if (ziua == 1)
            {
                label3.Text = ("Sunday");
            }
            if (ziua == 2)
            {
                label3.Text = ("Monday");
            }
            if (ziua == 3)
            {
                label3.Text = ("Tuesday");
            }
            if (ziua == 4)
            {
                label3.Text = ("Wednesday");
            }
            if (ziua == 5)
            {
                label3.Text = ("Thursday");
            }
            if (ziua == 6)
            {
                label3.Text = ("Friday");
            }
            if (label3.Text == "Monday" || label3.Text == "Tuesday" || label3.Text == "Thursday" || label3.Text == "Saturday")
            {
                label3.Location = button7.Location;
            }
            if (label3.Text == "Friday" || label3.Text == "Sunday")
            {
                label3.Location = button6.Location;
            }
            if (label3.Text == "Wednesday")
            {
                label3.Location = button8.Location;
            }
            if (comboBox1.Text != null && comboBox2.Text != null && comboBox3.Text != null)
            {





            }

            if (comboBox3.Text == null && comboBox2.Text == null && comboBox1.Text == null)
            {
                button2.Enabled = false;
            }
            label3.Visible = true;

        }
    }
    }

 

    

