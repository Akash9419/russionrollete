using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace russionroullete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class myclass = new Class();// class
        
        private void button_load_Click(object sender, EventArgs e)
        {

            myclass.WeaponReload(); // reload function
            button_load.Enabled = false;
            button_spin.Enabled = true;
            loadgun.Show();
            MessageBox.Show("Gun Reloaded");
            loadgun.Hide();
            point1.Hide();
            point2.Show();
        }

        private void button_spin_Click(object sender, EventArgs e)
        {
            myclass.Forspin(); // spin function
            SoundPlayer sound = new SoundPlayer();
            sound.Play();
            button_spin.Enabled = false;
            button_shoot.Enabled = true;
            button_shootaway.Enabled = true;
            spinner.Show();
            MessageBox.Show("Done");
            spinner.Hide();
            point2.Hide();
            point3.Show();
            point4.Show();

        }

        private void button_shoot_Click(object sender, EventArgs e)
        {
            myclass.Shoot();// shoot function
            point3.Hide();
            fire.Show();

        }

        private void button_shootaway_Click(object sender, EventArgs e)
        {

            myclass.AwayShooting(); // shoot away function
            point4.Hide();
            fire.Hide();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_shootaway.Enabled = false;
            button_shoot.Enabled = false;
            button_spin.Enabled = false;
            spinner.Hide();
            loadgun.Hide();
            point4.Hide();
            point3.Hide();
            point2.Hide();
            fire.Hide();
        }

        private void button_playagain_Click(object sender, EventArgs e)
        {
            myclass.reset(); // reset function
        }
    }
}
